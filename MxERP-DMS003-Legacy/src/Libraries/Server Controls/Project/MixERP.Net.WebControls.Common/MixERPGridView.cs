﻿using MixERP.Net.Common;
using MixERP.Net.i18n.Resources;
using System;
using System.Globalization;
using System.Web.UI.WebControls;
using MixERP.Net.i18n;

namespace MixERP.Net.WebControls.Common
{
    public sealed class MixERPGridView : GridView
    {
        private readonly bool htmlEncode;

        public MixERPGridView()
        {
            this.htmlEncode = true;
            this.Initialize();
        }

        public MixERPGridView(bool htmlEncode)
        {
            this.htmlEncode = htmlEncode;
            this.Initialize();
        }

        private void Initialize()
        {
            this.CssClass += "ui striped table ";
            this.GridLines = GridLines.None;
            this.EmptyDataText = CommonResource.NoRecordFound;
        }

        protected override void OnDataBound(EventArgs e)
        {
            if (this.Rows.Count.Equals(0))
            {
                return;
            }

            if (this.HeaderRow == null)
            {
                return;
            }

            this.HeaderRow.TableSection = TableRowSection.TableHeader;
            base.OnDataBound(e);
        }

        protected override void OnRowDataBound(GridViewRowEventArgs e)
        {
            if (e == null)
            {
                return;
            }

            foreach (TableCell cell in e.Row.Cells)
            {
                DataControlFieldCell dataControlField = cell as DataControlFieldCell;

                if (dataControlField != null)
                {
                    AutoGeneratedField field = dataControlField.ContainingField as AutoGeneratedField;

                    if (field != null)
                    {

                        field.HeaderStyle.CssClass = "text left";

                        switch (field.DataType.FullName)
                        {
                            case "System.String":
                                field.HtmlEncode = this.htmlEncode;
                            break;
                            case "System.Decimal":
                            case "System.Double":
                            case "System.Single":
                                cell.CssClass = "text right";
                                field.HeaderStyle.CssClass = "text right";

                                if (e.Row.RowType == DataControlRowType.DataRow)
                                {
                                    decimal value = Conversion.TryCastDecimal(cell.Text);

                                    if (!value.Equals(0))
                                    {
                                        CultureInfo culture = CultureManager.GetCurrent();
                                        cell.Text = value.ToString("C", culture).Replace(culture.NumberFormat.CurrencySymbol, "");
                                    }
                                }
                                break;
                            case "System.DateTime":
                                if (e.Row.RowType == DataControlRowType.DataRow)
                                {
                                    DateTime date = Conversion.TryCastDate(cell.Text);

                                    if (date.Date == date)
                                    {
                                        cell.Text = Conversion.TryCastDate(cell.Text).ToString("D", CultureManager.GetCurrent());
                                    }
                                    else
                                    {
                                        cell.Text = Conversion.TryCastDate(cell.Text).ToString("F", CultureManager.GetCurrent());
                                    }
                                }

                                break;
                        }

                    }
                }
            }

            base.OnRowDataBound(e);
        }
    }
}