﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_WEB.Models.DAO
{
    public static class Helper
    {
        // DataReader = >List<VO>
        public static List<T> DataReaderMapToList<T>(IDataReader dr)
        {
            try
            {
                List<T> list = new List<T>();
                T obj = default(T);
                while (dr.Read())
                {
                    obj = Activator.CreateInstance<T>();
                    foreach (PropertyInfo prop in obj.GetType().GetProperties())
                    {
                        //프로퍼티는 존재하는데, reader안에 조회된 컬럼이 없는 경우
                        //reader에 조회된 컬럼은 있는데, 프로퍼티는 정의되지 않은 경우
                        if (ContainsColumn(dr, prop.Name))
                        {
                            if (!object.Equals(dr[prop.Name], DBNull.Value))
                            {
                                //DataReader의 해당컬럼타입과 property의 타입이 일치해야한다.
                                prop.SetValue(obj, dr[prop.Name], null);
                            }
                        }
                    }
                    list.Add(obj);
                }
                return list;
            }
            catch (Exception err)
            {
                string msg = err.Message;
                return null;
            }
        }

        private static bool ContainsColumn(IDataReader reader, string columnName)
        {
            foreach (DataRow row in reader.GetSchemaTable().Rows)
            {
                if (row["ColumnName"].ToString() == columnName)
                    return true;
            }  
            return false;
        }

        // DataTable => List<VO>
        public static List<T> DataTableMapToList<T>(DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();
                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();
                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    list.Add(obj);
                }
                return list;
            }
            catch
            {
                return null;
            }
        }

        // List<VO> => DataTable 
        public static DataTable LinqQueryToDataTable(IEnumerable<dynamic> v)
        {
            //We really want to know if there is any data at all
            var firstRecord = v.FirstOrDefault();
            if (firstRecord == null)
                return null;

            //So dear record, what do you have?
            PropertyInfo[] infos = firstRecord.GetType().GetProperties();
            //Our table should have the columns to support the properties
            DataTable table = new DataTable();
            //Add, add, add the columns
            foreach (var info in infos)
            {
                Type propType = info.PropertyType;
                //Nullable types should be handled too
                if (propType.IsGenericType
                    && propType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    table.Columns.Add(info.Name, Nullable.GetUnderlyingType(propType));
                }
                else
                {
                    table.Columns.Add(info.Name, info.PropertyType);
                }
            }

            DataRow row;
            foreach (var record in v)
            {
                row = table.NewRow();
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    row[i] = infos[i].GetValue(record) != null ?
 infos[i].GetValue(record) : DBNull.Value;
                }
                table.Rows.Add(row);
            }

            //Table is ready to serve.
            table.AcceptChanges();
            return table;
        }
    }
}