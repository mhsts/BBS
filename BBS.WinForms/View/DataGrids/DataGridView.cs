using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BBS.View.DataLists
{
    public partial class DataGridView : UserControl
    {
        private DataGridViewButtonColumn editButtonColumn;
        private DataGridViewButtonColumn deleteButtonColumn;

        public DataGridView()
        {
            InitializeComponent();
            gridView.CellFormatting += GridViewCellFormatting;
            gridView.CellPainting += GridViewCellPainting;
            gridView.CellClick += GridViewCellClick;
        }

        void GridViewCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var column = gridView.Columns[e.ColumnIndex];

            if (OnCellFormatting != null)
            {
                OnCellFormatting(column.DataPropertyName, e.Value, e.CellStyle);
            }
        }

        void GridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var column = gridView.Columns[e.ColumnIndex];

            if (column == editButtonColumn)
            {
                if (OnEditClicked != null)
                {
                    OnEditClicked(GetRowData(e));
                }
            }
            else if (column == deleteButtonColumn)
            {
                if (OnDeleteClicked != null)
                {
                    OnDeleteClicked(GetRowData(e));
                }
            }
        }

        private object GetRowData(DataGridViewCellEventArgs e)
        {
            return gridView.Rows[e.RowIndex].DataBoundItem;            
        }

        public Action<object> OnEditClicked;
        public Action<object> OnDeleteClicked;
        public Action<string, object, DataGridViewCellStyle> OnCellFormatting;

        private void DrawCellBackground(DataGridViewCellPaintingEventArgs e)
        {
            using (
                Brush gridBrush = new SolidBrush(gridView.GridColor),
                backColorBrush = new SolidBrush(e.CellStyle.BackColor))
            {
                using (Pen gridLinePen = new Pen(gridBrush))
                {
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                        e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                        e.CellBounds.Bottom - 1);
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                        e.CellBounds.Top, e.CellBounds.Right - 1,
                        e.CellBounds.Bottom);
                }
            }        
        }

        void GridViewCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var image = gridView.Columns[e.ColumnIndex].Tag as Bitmap;

            if (image == null) 
                return;

            DrawCellBackground(e);

            var xOffset = (e.CellBounds.Width - 32f) / 2f;
            var yOffset = (e.CellBounds.Height - 32f) / 2f;
            e.Graphics.DrawImage(image, e.CellBounds.Left + xOffset, e.CellBounds.Top + yOffset, 32f, 32f);
            e.Handled = true;
        }

        public void SetData(IList data)
        {
            var selectedRow = GetSelectedRowIndex();

            gridView.Columns.Clear();

            gridView.DataSource = data;

            editButtonColumn = AddButtonColumn(Properties.Resources.edit1);
            deleteButtonColumn = AddButtonColumn(Properties.Resources.delete);

            if (selectedRow >= 0 && selectedRow < gridView.Rows.Count)
                gridView.Rows[selectedRow].Selected = true;
        }

        private int GetSelectedRowIndex()
        {
            if (gridView.SelectedRows.Count > 0)
            {
                return gridView.SelectedRows[0].Index;
            }
            return -1;
        }

        private DataGridViewButtonColumn AddButtonColumn(Bitmap image)
        {
            var buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Width = 45;
            buttonColumn.Resizable = DataGridViewTriState.False;
            buttonColumn.Tag = image;

            gridView.Columns.Add(buttonColumn);
            return buttonColumn;
        }
    }
}
