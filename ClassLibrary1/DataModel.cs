using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class DataModel
    {


        #region INSERT

        public static long Create<T>(this T item, DbContext ctx, string CommentsForHistory = null) where T : class, new()
        {
            return item.CreateItem(ctx, CommentsForHistory);
        }

        public static long Create<T>(this T item, string CommentsForHistory = null) where T : class, new()
        {
            long ItemID = -1;
            using (var ctx = new DbContext())
            {
                try
                {
                    ctx.BeginTransaction();
                    ItemID = item.CreateItem(ctx, CommentsForHistory);
                    ctx.CommitTransaction();
                }
                catch
                {
                    ctx.RollbackTransaction();
                    throw;
                }
            }

            return ItemID;
        }

        private static long CreateItem<T>(this T item, DbContext ctx, string CommentsForHistory = null) where T : class, new()
        {
            long newId = -1;
            Type t = typeof(T);

            if (t.InheritsFrom(typeof(MainModel)))
            {
                ((MainModel)(object)item).DateCreated = DateTime.Now;
                //((MainModel)(object)item).UserCreated = Globals.CurrentUser != null ? Globals.CurrentUser.usr_id : -1;
            }

            newId = Utils.GetLong(ctx.ExecScalar(t.DatabaseInsertTable(item)));

            //UpdateHistory<T>(new IQ_EntityHistory()
            //{
            //    ItemID = newId.ToString(),
            //    Action = EntityHistoryType.Created.ToString(),
            //    Content = string.Empty,
            //    Comments = CommentsForHistory
            //}, ctx);

            return newId;
        }

        #endregion

        #region UPDATE

        public static string Update<T>(this T item, DbContext ctx, string[] updateOnly = null, string CommentsForHistory = null) where T : class, new()
        {
            return item.UpdateItem(ctx, updateOnly, CommentsForHistory);
        }

        public static string Update<T>(this T item, string[] updateOnly = null, string CommentsForHistory = null) where T : class, new()
        {
            string ItemID = "-1";
            using (var ctx = new DbContext())
            {
                try
                {
                    ctx.BeginTransaction();
                    ItemID = item.UpdateItem(ctx, updateOnly, CommentsForHistory);
                    ctx.CommitTransaction();
                }
                catch
                {
                    ctx.RollbackTransaction();
                    throw;
                }
            }

            return ItemID;
        }

        private static string UpdateItem<T>(this T item, DbContext ctx, string[] updateOnly = null, string CommentsForHistory = null) where T : class, new()
        {
            Type t = item.GetType();

            if (t.InheritsFrom(typeof(MainModel)))
            {
                ((MainModel)(object)item).DateModified = DateTime.Now;
                //((MainModel)(object)item).UserModified = Globals.CurrentUser != null ? Globals.CurrentUser.usr_id : -1;
            }

            //// Save entity history
            //string ItemID = Utils.GetString(item.GetPropValueForSql(t.DatabasePrimaryKey()));
            //string Content = string.Empty;
            //List<EntityHistoryContentValues> ChangedProperties = PublicInstancePropertiesChanged(Get<T>(ItemID, ctx), item, updateOnly);
            //if (ChangedProperties.Count > 0)
            //    Content = JsonConvert.SerializeObject(ChangedProperties);

            //// Update history if something was modified
            //if (string.IsNullOrWhiteSpace(Content) == false)
            //{
            //    UpdateHistory<T>(new IQ_EntityHistory()
            //    {
            //        ItemID = ItemID,
            //        Action = EntityHistoryType.Modified.ToString(),
            //        Content = Content,
            //        Comments = CommentsForHistory
            //    }, ctx);
            //}

            return Utils.GetString(ctx.ExecScalar(t.DatabaseUpdateTable(item, updateOnly)));
        }

        #endregion

        //#region HISTORY
        //public static void UpdateHistory<T>(IQ_EntityHistory HistoryItem, DbContext ctx = null) where T : class, new()
        //{
        //    UpdateItemHistory<T>(HistoryItem, ctx);
        //}

        //public static void UpdateHistory<T>(IQ_EntityHistory HistoryItem) where T : class, new()
        //{
        //    using (var ctx = new DbContext())
        //    {
        //        try
        //        {
        //            ctx.BeginTransaction();
        //            UpdateItemHistory<T>(HistoryItem, ctx);
        //            ctx.CommitTransaction();
        //        }
        //        catch
        //        {
        //            ctx.RollbackTransaction();
        //            throw;
        //        }
        //    }
        //}

        //private static void UpdateItemHistory<T>(IQ_EntityHistory HistoryItem, DbContext ctx) where T : class, new()
        //{
        //    if ((HistoryItem.ItemID != null && HistoryItem.ItemID.StartsWith("N'")) || Utils.GetLong(HistoryItem.ItemID) > 0)// Avoid saving history records for items that are still not saved to database
        //    {
        //        Type t = typeof(T);
        //        if (typeof(IHistoryEnabled).IsAssignableFrom(t))
        //        {
        //            HistoryItem.ItemID = HistoryItem.ItemID.Trim('N').Trim('\'');
        //            HistoryItem.DBTable = t.DatabaseTable();
        //            HistoryItem.Create(ctx);
        //        }
        //    }
        //}

        //public class EntityHistoryContentValues
        //{
        //    public EntityHistoryContentValues()
        //    {

        //    }
        //    public string Title { get; set; }
        //    public object Value { get; set; }
        //}

        //public static List<EntityHistoryContentValues> PublicInstancePropertiesChanged<T>(T self, T to, string[] includeOnly)
        //{
        //    Type t = typeof(T);
        //    List<PropertyInfo> ItemProperties = t.GetProperties().ToList();

        //    List<DatabaseColumn> fields = t.DatabaseFieldsAttributes();

        //    // at first use only fields that are marked as IgnoreHistory = false
        //    List<string> FieldsToTakeIntoNotice = fields.Where(x => x.IgnoreHistory == false).Select(x => x.Name).ToList();

        //    // If includeOnly is set, use these fields
        //    if (includeOnly != null)
        //        FieldsToTakeIntoNotice = includeOnly.ToList();

        //    // TODO: AT LAST, change this column name from Licence# to Licence
        //    if (FieldsToTakeIntoNotice.Contains("Licence#"))
        //        for (int i = 0; i < FieldsToTakeIntoNotice.Count; i++)
        //            if (FieldsToTakeIntoNotice[i].Equals("Licence#"))
        //                FieldsToTakeIntoNotice[i] = "Licence";

        //    List<EntityHistoryContentValues> result = new List<EntityHistoryContentValues>();
        //    IEnumerable<GridAttribute> GridAttributes = t.GridAllColumnsAttributes();
        //    if (self != null && to != null)
        //    {
        //        foreach (var prop in ItemProperties)
        //        {
        //            if (FieldsToTakeIntoNotice.Contains(prop.Name))
        //            {
        //                object selfValue = t.GetProperty(prop.Name).GetValue(self, null);
        //                object toValue = t.GetProperty(prop.Name).GetValue(to, null);

        //                if (prop.PropertyType.Equals(typeof(string)))// Handle strings null or empty as the same
        //                {
        //                    selfValue = Utils.GetString(t.GetProperty(prop.Name).GetValue(self, null));
        //                    toValue = Utils.GetString(t.GetProperty(prop.Name).GetValue(to, null));
        //                }

        //                if (selfValue != toValue && (selfValue == null || !selfValue.Equals(toValue)))
        //                {
        //                    // Hide history from encrypted columns
        //                    DatabaseColumn column = fields.SingleOrDefault(x => x.Name.Equals(prop.Name));
        //                    if (column != null && column.Encrypted)
        //                    {
        //                        selfValue = "********";
        //                        toValue = "********";
        //                    }

        //                    EntityHistoryContentValues NewItem = new EntityHistoryContentValues() { Title = prop.Name };
        //                    List<string> Values = new List<string>();
        //                    Values.Add(GetPropertyForeighnKeyDescriptionValue(t, GridAttributes.SingleOrDefault(x => x.Name.Equals(prop.Name)), Utils.GetString(selfValue)));
        //                    Values.Add(GetPropertyForeighnKeyDescriptionValue(t, GridAttributes.SingleOrDefault(x => x.Name.Equals(prop.Name)), Utils.GetString(toValue)));
        //                    NewItem.Value = Values;
        //                    result.Add(NewItem);
        //                }
        //            }
        //        }
        //    }

        //    return result;
        //}

        //public static string GetPropertyForeighnKeyDescriptionValue(Type t, GridAttribute gridAttribute, string ItemID)
        //{
        //    //// Search for foreighn key description values
        //    if (gridAttribute != null && gridAttribute.ForeignKeyType != null)
        //    {
        //        // Get foreigh key values from database
        //        MethodInfo method = typeof(DataModel).GetMethod(nameof(DataModel.Get), new[] { typeof(string), typeof(DbContext), typeof(string[]), typeof(string[]) });
        //        MethodInfo generic = method.MakeGenericMethod(gridAttribute.ForeignKeyType);
        //        var ItemOldValueObj = generic.Invoke(null, new object[] { ItemID, null, null, new string[] { gridAttribute.ForeignKeyDisplayMember } });// Get description value

        //        PropertyInfo FieldDescriptionPropertyInfo = gridAttribute.ForeignKeyType.GetProperties().SingleOrDefault(x => x.Name.Equals(gridAttribute.ForeignKeyDisplayMember));
        //        if (FieldDescriptionPropertyInfo != null && ItemOldValueObj != null)
        //            return Utils.GetString(FieldDescriptionPropertyInfo.GetValue(ItemOldValueObj));
        //    }

        //    return ItemID;
        //}

        //#endregion

        #region DELETE

        public static void Delete<T>(this T item, DbContext ctx) where T : class, new()
        {
            item.DeleteItem(ctx);
        }

        public static void Delete<T>(this T item) where T : class, new()
        {
            using (var ctx = new DbContext())
            {
                try
                {
                    ctx.BeginTransaction();
                    item.DeleteItem(ctx);
                    ctx.CommitTransaction();
                }
                catch
                {
                    ctx.RollbackTransaction();
                    throw;
                }
            }
        }

        public static void DeleteItem<T>(this T item, DbContext ctx) where T : class, new()
        {
            Type t = typeof(T);
            // Save to history if this item is history enabled
            string ItemID = Utils.GetString(item.GetPropValueForSql(t.DatabasePrimaryKey()));

            //UpdateHistory<T>(new IQ_EntityHistory()
            //{
            //    Action = EntityHistoryType.Deleted.ToString(),
            //    ItemID = ItemID,
            //    Content = JsonConvert.SerializeObject(item)//Fill(item)
            //}, ctx);

            ctx.ExecNQ(t.DatabaseDeleteItem(item));
        }

        //private static string Fill<T>(this T item) where T : class, new()
        //{
        //    Type t = typeof(T);
        //    IEnumerable<GridAttribute> GridAttributes = t.GridAllColumnsAttributes();
        //    JObject o = (JObject)JToken.FromObject(item);
        //    foreach (var token in o)
        //    {
        //        o[token.Key] = GetPropertyForeighnKeyDescriptionValue(t, GridAttributes.SingleOrDefault(x => x.Name.Equals(token.Key)), o[token.Key].ToString());
        //    }

        //    return o.ToString();
        //}

        //public static void Delete<T>(this List<T> items, DbContext ctx) where T : class, new()
        //{
        //    items.DeleteItems(ctx);
        //}

        //public static void Delete<T>(this List<T> items) where T : class, new()
        //{
        //    using (var ctx = new DbContext())
        //    {
        //        try
        //        {
        //            ctx.BeginTransaction();
        //            items.DeleteItems(ctx);
        //            ctx.CommitTransaction();
        //        }
        //        catch
        //        {
        //            ctx.RollbackTransaction();
        //            throw;
        //        }
        //    }
        //}

        //public static void DeleteItems<T>(this List<T> item, DbContext ctx) where T : class, new()
        //{
        //    Type t = typeof(T);
        //    ctx.ExecNQ(t.DatabaseDeleteItems(item.ToList<object>()));
        //}

        #endregion

        #region GENERAL

        public static object ExecScalar(string cmd, DbContext ctx)
        {
            return ctx.ExecScalar(cmd);
        }

        public static object ExecScalar(string cmd)
        {
            using (DbContext ctx = new DbContext())
            {
                return ctx.ExecScalar(cmd);
            }
        }

        public static int ExecNQ(string cmd, DbContext ctx)
        {
            return ctx.ExecNQ(cmd);
        }

        public static int ExecNQ(string cmd)
        {
            using (DbContext ctx = new DbContext())
            {
                return ctx.ExecNQ(cmd);
            }
        }

        public static DataTable ExecTable(string cmd, DbContext ctx)
        {
            return ctx.ExecTable(cmd);
        }

        public static DataTable ExecTable(string cmd)
        {
            using (DbContext ctx = new DbContext())
            {
                return ctx.ExecTable(cmd);
            }
        }

        //public static SqlDataReader ExecuteSelectAsReader(string sql)
        //{
        //    return ExecuteSelectAsReader(sql, null);
        //}

        //private static SqlCommand lastCommand = null;

        //public static void CancelLastCommand()
        //{
        //    if (lastCommand != null)
        //    {
        //        Console.WriteLine("Calling Cancel lastCommand = valid");
        //        lastCommand.Cancel();
        //    }
        //    else
        //        Console.WriteLine("Calling Cancel lastCommand = null");
        //}

        //public static SqlDataReader ExecuteSelectAsReader(string sql, List<SqlParameter> parameters)
        //{
        //    if (!CheckConnection())
        //        return null;

        //    //Console.WriteLine(string.Format("{0} ExecuteSelectAsReader \r\n{1}", Thread.CurrentThread.ManagedThreadId, sql));
        //    SqlCommand cmd = new SqlCommand();
        //    SqlTransaction transaction = _Connection.BeginTransaction(IsolationLevel.ReadUncommitted);
        //    cmd.Connection = _Connection;
        //    cmd.Transaction = transaction;
        //    cmd.CommandType = CommandType.Text;

        //    cmd.CommandText = sql;
        //    lastCommand = cmd;

        //    if (parameters != null)
        //    {
        //        cmd.Parameters.AddRange(parameters.ToArray());
        //    }

        //    try
        //    {
        //        transaction.Commit();
        //        _lastReader = cmd.ExecuteReader();
        //    }
        //    catch (Exception ex)
        //    {
        //        MobilityAddons.Logging.LogException("DBHelper:ExecuteSelectAsReader : {0}", ex);
        //        HandleException(ex);

        //        try
        //        {
        //            transaction.Rollback();
        //        }
        //        catch (Exception ex2)
        //        {
        //            MobilityAddons.Logging.LogException("DBHelper:ExecuteSelectAsReader : {0}", ex2);
        //            HandleException(ex2);
        //        }

        //    }
        //    finally
        //    {
        //        lastCommand = null;
        //        cmd.Dispose();
        //    }
        //    return _lastReader;
        //}

        //public static DataTable ExecuteSelectAsDataTable(string sql)
        //{
        //    return ExecuteSelectAsDataTable(sql, null);
        //}

        //public static DataTable ExecuteSelectAsDataTable(string sql, List<SqlParameter> parameters)
        //{
        //    SqlDataReader reader = ExecuteSelectAsReader(sql, parameters);
        //    if (reader != null)
        //    {
        //        DataTable dt = new DataTable();
        //        dt.Load(reader);
        //        return dt;
        //    }
        //    return null;
        //}

        public static DbDataReader ExecReader(string sql)
        {
            using (DbContext ctx = new DbContext())
            {
                return ctx.ExecReader(sql);
            }
        }

        #endregion

        #region HELPERS

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

        public static List<T> GetListFromDataTable<T>(DataTable table) where T : class, new()
        {
            List<T> list = new List<T>();
            if (table != null)
            {
                foreach (var row in table.AsEnumerable())
                    list.Add(GetObjectFromDataRow<T>(row));
                table.Dispose();
            }
            return list;
        }


        public static T GetObjectFromDataRow<T>(DataRow row) where T : class, new()
        {
            T obj = new T();
            foreach (var prop in obj.GetType().GetProperties())
            {
                PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                Type propType = propertyInfo.PropertyType;

                // If there is no setter for this property
                if (propertyInfo.SetMethod == null)
                    continue;

                string ColumnName = prop.Name;

                //if (obj.GetType().Equals(typeof(IQ_Driver)) && ColumnName.Equals(nameof(IQ_Driver.Licence)))// Whatever....
                //    ColumnName = nameof(IQ_Driver.Licence) + "#";

                if (row.Table.Columns.Contains(ColumnName))
                {
                    object value = row[ColumnName];

                    if (value == null || value == DBNull.Value)
                    {
                        if (propertyInfo.PropertyType == typeof(string))
                            propertyInfo.SetValue(obj, string.Empty, null);
                        else
                            propertyInfo.SetValue(obj, null, null);
                    }
                    else
                    {
                        // If it is nullable
                        if (propType.IsGenericType && propType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                        {
                            if (propType == typeof(int?))
                            {
                                value = Utils.GetNullInt(value);
                                propertyInfo.SetValue(obj, ChangeType<int>(value), null);
                            }
                            else if (propType == typeof(long?))
                            {
                                value = Utils.GetNullLong(value);
                                propertyInfo.SetValue(obj, ChangeType<long>(value), null);
                            }
                            else if (propType == typeof(decimal?))
                            {
                                value = Utils.GetNullDecimal(value);
                                propertyInfo.SetValue(obj, ChangeType<decimal>(value), null);
                            }
                            else if (propType == typeof(float?))
                            {
                                value = Utils.GetNullFloat(value);
                                propertyInfo.SetValue(obj, ChangeType<float>(value), null);
                            }
                            else if (propType == typeof(double?))
                            {
                                value = Utils.GetNullDouble(value);
                                propertyInfo.SetValue(obj, ChangeType<double>(value), null);
                            }
                            else if (propType == typeof(bool?))
                            {
                                value = Utils.GetNullBool(value);
                                propertyInfo.SetValue(obj, ChangeType<bool>(value), null);
                            }
                            else if (propType == typeof(DateTime?))
                            {
                                //TODO propType = typeof(DateTime); DateTime temp; if (DateTime.TryParse(Utils.GetString(value), out temp)) { value = temp; } else { value = new DateTime(1900, 1, 1); }
                                propertyInfo.SetValue(obj, ChangeType<DateTime>(value), null);
                            }
                        }
                        else// If the type is not nullable
                        {
                            if (propType == typeof(int)) { value = Utils.GetInt(value, 0); }
                            else if (propType == typeof(long)) { value = Utils.GetLong(value, 0); }
                            else if (propType == typeof(float)) { value = Utils.GetFloat(value, 0); }
                            else if (propType == typeof(double)) { value = Utils.GetDouble(value, 0); }
                            else if (propType == typeof(decimal)) { value = Utils.GetDecimal(value, 0); }
                            else if (propType == typeof(bool)) { value = Utils.GetBool(value, false); }
                            else if (propType == typeof(DateTime)) { value = Utils.GetDate(value, new DateTime(1700, 1, 1)); }
                            propertyInfo.SetValue(obj, Convert.ChangeType(value, propType), null);
                        }
                    }
                }
            }

            return obj;
        }

        public static T ChangeType<T>(object value)
        {
            var t = typeof(T);

            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                {
                    return default(T);
                }

                t = Nullable.GetUnderlyingType(t);
            }

            return (T)Convert.ChangeType(value, t);
        }

        #endregion


    }
}
