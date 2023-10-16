﻿using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AppForms.AppForms;

[ConnectionKey("AppForms"), Module("AppForms"), TableName("Specialities")]
[DisplayName("Specialities"), InstanceName("Specialities")]
[ReadPermission("Specialities")]
[ModifyPermission("Specialities")]
public sealed class SpecialitiesRow : Row<SpecialitiesRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Name"), NotNull, QuickSearch, NameProperty]
    public string Name
    {
        get => fields.Name[this];
        set => fields.Name[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;

    }
}