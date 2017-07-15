﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.2914.16
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace QueryExpress {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class DSSettings : System.Data.DataSet {
        
        private settingsDataTable tablesettings;
        
        public DSSettings() {
            this.InitClass();
        }
        
        private DSSettings(SerializationInfo info, StreamingContext context) {
            this.InitClass();
            this.GetSerializationData(info, context);
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public settingsDataTable settings {
            get {
                return this.tablesettings;
            }
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.ReadXml(reader, XmlReadMode.IgnoreSchema);
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        private void InitClass() {
            this.DataSetName = "DSSettings";
            this.Namespace = "http://tempuri.org/DSSettings.xsd";
            this.tablesettings = new settingsDataTable();
            this.Tables.Add(this.tablesettings);
        }
        
        private bool ShouldSerializesettings() {
            return false;
        }
        
        public delegate void settingsRowChangeEventHandler(object sender, settingsRowChangeEvent e);
        
        public class settingsDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnConnectionPage;
            
            private DataColumn columnSqlServer;
            
            private DataColumn columnSqlDatabase;
            
            private DataColumn columnSqlTrusted;
            
            private DataColumn columnSqlLoginName;
            
            private DataColumn columnOleDbConnect;
            
            private DataColumn columnOraDataSource;
            
            private DataColumn columnOraLoginName;
            
            private DataColumn columnOraMSDriver;
            
            private DataColumn columnMdiParentMaximized;
            
            private DataColumn columnMdiChildMaximized;
            
            internal settingsDataTable() : 
                    base("settings") {
                this.InitClass();
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn ConnectionPageColumn {
                get {
                    return this.columnConnectionPage;
                }
            }
            
            internal DataColumn SqlServerColumn {
                get {
                    return this.columnSqlServer;
                }
            }
            
            internal DataColumn SqlDatabaseColumn {
                get {
                    return this.columnSqlDatabase;
                }
            }
            
            internal DataColumn SqlTrustedColumn {
                get {
                    return this.columnSqlTrusted;
                }
            }
            
            internal DataColumn SqlLoginNameColumn {
                get {
                    return this.columnSqlLoginName;
                }
            }
            
            internal DataColumn OleDbConnectColumn {
                get {
                    return this.columnOleDbConnect;
                }
            }
            
            internal DataColumn OraDataSourceColumn {
                get {
                    return this.columnOraDataSource;
                }
            }
            
            internal DataColumn OraLoginNameColumn {
                get {
                    return this.columnOraLoginName;
                }
            }
            
            internal DataColumn OraMSDriverColumn {
                get {
                    return this.columnOraMSDriver;
                }
            }
            
            internal DataColumn MdiParentMaximizedColumn {
                get {
                    return this.columnMdiParentMaximized;
                }
            }
            
            internal DataColumn MdiChildMaximizedColumn {
                get {
                    return this.columnMdiChildMaximized;
                }
            }
            
            public settingsRow this[int index] {
                get {
                    return ((settingsRow)(this.Rows[index]));
                }
            }
            
            public event settingsRowChangeEventHandler settingsRowChanged;
            
            public event settingsRowChangeEventHandler settingsRowChanging;
            
            public event settingsRowChangeEventHandler settingsRowDeleted;
            
            public event settingsRowChangeEventHandler settingsRowDeleting;
            
            public void AddsettingsRow(settingsRow row) {
                this.Rows.Add(row);
            }
            
            public settingsRow AddsettingsRow(int ConnectionPage, string SqlServer, string SqlDatabase, bool SqlTrusted, string SqlLoginName, string OleDbConnect, string OraDataSource, string OraLoginName, bool OraMSDriver, bool MdiParentMaximized, bool MdiChildMaximized) {
                settingsRow rowsettingsRow = ((settingsRow)(this.NewRow()));
                rowsettingsRow.ItemArray = new object[] {
                        ConnectionPage,
                        SqlServer,
                        SqlDatabase,
                        SqlTrusted,
                        SqlLoginName,
                        OleDbConnect,
                        OraDataSource,
                        OraLoginName,
                        OraMSDriver,
                        MdiParentMaximized,
                        MdiChildMaximized};
                this.Rows.Add(rowsettingsRow);
                return rowsettingsRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            private void InitClass() {
                this.columnConnectionPage = new DataColumn("ConnectionPage", typeof(int), "", System.Data.MappingType.Element);
                this.Columns.Add(this.columnConnectionPage);
                this.columnSqlServer = new DataColumn("SqlServer", typeof(string), "", System.Data.MappingType.Element);
                this.Columns.Add(this.columnSqlServer);
                this.columnSqlDatabase = new DataColumn("SqlDatabase", typeof(string), "", System.Data.MappingType.Element);
                this.columnSqlDatabase.AllowDBNull = false;
                this.Columns.Add(this.columnSqlDatabase);
                this.columnSqlTrusted = new DataColumn("SqlTrusted", typeof(bool), "", System.Data.MappingType.Element);
                this.Columns.Add(this.columnSqlTrusted);
                this.columnSqlLoginName = new DataColumn("SqlLoginName", typeof(string), "", System.Data.MappingType.Element);
                this.Columns.Add(this.columnSqlLoginName);
                this.columnOleDbConnect = new DataColumn("OleDbConnect", typeof(string), "", System.Data.MappingType.Element);
                this.Columns.Add(this.columnOleDbConnect);
                this.columnOraDataSource = new DataColumn("OraDataSource", typeof(string), "", System.Data.MappingType.Element);
                this.Columns.Add(this.columnOraDataSource);
                this.columnOraLoginName = new DataColumn("OraLoginName", typeof(string), "", System.Data.MappingType.Element);
                this.Columns.Add(this.columnOraLoginName);
                this.columnOraMSDriver = new DataColumn("OraMSDriver", typeof(bool), "", System.Data.MappingType.Element);
                this.Columns.Add(this.columnOraMSDriver);
                this.columnMdiParentMaximized = new DataColumn("MdiParentMaximized", typeof(bool), "", System.Data.MappingType.Element);
                this.Columns.Add(this.columnMdiParentMaximized);
                this.columnMdiChildMaximized = new DataColumn("MdiChildMaximized", typeof(bool), "", System.Data.MappingType.Element);
                this.Columns.Add(this.columnMdiChildMaximized);
            }
            
            public settingsRow NewsettingsRow() {
                return ((settingsRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                // We need to ensure that all Rows in the tabled are typed rows.
                // Table calls newRow whenever it needs to create a row.
                // So the following conditions are covered by Row newRow(Record record)
                // * Cursor calls table.addRecord(record) 
                // * table.addRow(object[] values) calls newRow(record)    
                return new settingsRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(settingsRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.settingsRowChanged != null)) {
                    this.settingsRowChanged(this, new settingsRowChangeEvent(((settingsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.settingsRowChanging != null)) {
                    this.settingsRowChanging(this, new settingsRowChangeEvent(((settingsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.settingsRowDeleted != null)) {
                    this.settingsRowDeleted(this, new settingsRowChangeEvent(((settingsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.settingsRowDeleting != null)) {
                    this.settingsRowDeleting(this, new settingsRowChangeEvent(((settingsRow)(e.Row)), e.Action));
                }
            }
            
            public void RemovesettingsRow(settingsRow row) {
                this.Rows.Remove(row);
            }
        }
        
        public class settingsRow : DataRow {
            
            private settingsDataTable tablesettings;
            
            internal settingsRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesettings = ((settingsDataTable)(this.Table));
            }
            
            public int ConnectionPage {
                get {
                    try {
                        return ((int)(this[this.tablesettings.ConnectionPageColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesettings.ConnectionPageColumn] = value;
                }
            }
            
            public string SqlServer {
                get {
                    try {
                        return ((string)(this[this.tablesettings.SqlServerColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesettings.SqlServerColumn] = value;
                }
            }
            
            public string SqlDatabase {
                get {
                    return ((string)(this[this.tablesettings.SqlDatabaseColumn]));
                }
                set {
                    this[this.tablesettings.SqlDatabaseColumn] = value;
                }
            }
            
            public bool SqlTrusted {
                get {
                    try {
                        return ((bool)(this[this.tablesettings.SqlTrustedColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesettings.SqlTrustedColumn] = value;
                }
            }
            
            public string SqlLoginName {
                get {
                    try {
                        return ((string)(this[this.tablesettings.SqlLoginNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesettings.SqlLoginNameColumn] = value;
                }
            }
            
            public string OleDbConnect {
                get {
                    try {
                        return ((string)(this[this.tablesettings.OleDbConnectColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesettings.OleDbConnectColumn] = value;
                }
            }
            
            public string OraDataSource {
                get {
                    try {
                        return ((string)(this[this.tablesettings.OraDataSourceColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesettings.OraDataSourceColumn] = value;
                }
            }
            
            public string OraLoginName {
                get {
                    try {
                        return ((string)(this[this.tablesettings.OraLoginNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesettings.OraLoginNameColumn] = value;
                }
            }
            
            public bool OraMSDriver {
                get {
                    try {
                        return ((bool)(this[this.tablesettings.OraMSDriverColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesettings.OraMSDriverColumn] = value;
                }
            }
            
            public bool MdiParentMaximized {
                get {
                    try {
                        return ((bool)(this[this.tablesettings.MdiParentMaximizedColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesettings.MdiParentMaximizedColumn] = value;
                }
            }
            
            public bool MdiChildMaximized {
                get {
                    try {
                        return ((bool)(this[this.tablesettings.MdiChildMaximizedColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesettings.MdiChildMaximizedColumn] = value;
                }
            }
            
            public bool IsConnectionPageNull() {
                return this.IsNull(this.tablesettings.ConnectionPageColumn);
            }
            
            public void SetConnectionPageNull() {
                this[this.tablesettings.ConnectionPageColumn] = System.Convert.DBNull;
            }
            
            public bool IsSqlServerNull() {
                return this.IsNull(this.tablesettings.SqlServerColumn);
            }
            
            public void SetSqlServerNull() {
                this[this.tablesettings.SqlServerColumn] = System.Convert.DBNull;
            }
            
            public bool IsSqlTrustedNull() {
                return this.IsNull(this.tablesettings.SqlTrustedColumn);
            }
            
            public void SetSqlTrustedNull() {
                this[this.tablesettings.SqlTrustedColumn] = System.Convert.DBNull;
            }
            
            public bool IsSqlLoginNameNull() {
                return this.IsNull(this.tablesettings.SqlLoginNameColumn);
            }
            
            public void SetSqlLoginNameNull() {
                this[this.tablesettings.SqlLoginNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsOleDbConnectNull() {
                return this.IsNull(this.tablesettings.OleDbConnectColumn);
            }
            
            public void SetOleDbConnectNull() {
                this[this.tablesettings.OleDbConnectColumn] = System.Convert.DBNull;
            }
            
            public bool IsOraDataSourceNull() {
                return this.IsNull(this.tablesettings.OraDataSourceColumn);
            }
            
            public void SetOraDataSourceNull() {
                this[this.tablesettings.OraDataSourceColumn] = System.Convert.DBNull;
            }
            
            public bool IsOraLoginNameNull() {
                return this.IsNull(this.tablesettings.OraLoginNameColumn);
            }
            
            public void SetOraLoginNameNull() {
                this[this.tablesettings.OraLoginNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsOraMSDriverNull() {
                return this.IsNull(this.tablesettings.OraMSDriverColumn);
            }
            
            public void SetOraMSDriverNull() {
                this[this.tablesettings.OraMSDriverColumn] = System.Convert.DBNull;
            }
            
            public bool IsMdiParentMaximizedNull() {
                return this.IsNull(this.tablesettings.MdiParentMaximizedColumn);
            }
            
            public void SetMdiParentMaximizedNull() {
                this[this.tablesettings.MdiParentMaximizedColumn] = System.Convert.DBNull;
            }
            
            public bool IsMdiChildMaximizedNull() {
                return this.IsNull(this.tablesettings.MdiChildMaximizedColumn);
            }
            
            public void SetMdiChildMaximizedNull() {
                this[this.tablesettings.MdiChildMaximizedColumn] = System.Convert.DBNull;
            }
        }
        
        public class settingsRowChangeEvent : EventArgs {
            
            private settingsRow eventRow;
            
            private System.Data.DataRowAction eventAction;
            
            public settingsRowChangeEvent(settingsRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public settingsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}