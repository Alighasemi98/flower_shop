using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace flower_shop.Class
{
  /*  internal class imageadress
    {
        public static int ImageHeight;
        public static int ImageWidth;
        public static string adress;
    }
    public class DGVPrinter
    {
        #region global variables

        DataGridView dgv = null;
        PrintDocument printDoc = null;
        IList rowstoprint;
        IList colstoprint;
        int lastrowprinted = -1;
        int fromPage = 0;
        int toPage = -1;
        int pageHeight = 0;
        int pageWidth = 0;
        int printWidth = 0;
        float rowheaderwidth = 0;
        int CurrentPage = 0;
        PrintRange printRange;
        private float headerHeight = 0;
        private float footerHeight = 0;
        private float pagenumberHeight = 0;
        private float colheaderheight = 0;
        private float coltotalwidth = 0;
        private List<float> rowheights;
        private List<float> colwidths;
        #endregion

        #region properties

        #region title properties

        bool overridetitleformat = false;
        private String title;
        public String Title
        {
            get { return title; }
            set { title = value; printDoc.DocumentName = title; }
        }
        private Font titlefont;
        public Font TitleFont
        {
            get { return titlefont; }
            set { titlefont = value; }
        }
        private Color titlecolor;
        public Color TitleColor
        {
            get { return titlecolor; }
            set { titlecolor = value; }
        }
        private StringAlignment titlealignment;
        public StringAlignment TitleAlignment
        {
            get { return titlealignment; }
            set { titlealignment = value; overridetitleformat = true; }
        }
        private StringFormatFlags titleformatflags;
        public StringFormatFlags TitleFormatFlags
        {
            get { return titleformatflags; }
            set { titleformatflags = value; overridetitleformat = true; }
        }
        #endregion

        #region subtitle properties

        bool overridesubtitleformat = false;
        private String subtitle;
        public String SubTitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }
        private Font subtitlefont;
        public Font SubTitleFont
        {
            get { return subtitlefont; }
            set { subtitlefont = value; }
        }
        private Color subtitlecolor;
        public Color SubTitleColor
        {
            get { return subtitlecolor; }
            set { subtitlecolor = value; }
        }
        private StringAlignment subtitlealignment;
        public StringAlignment SubTitleAlignment
        {
            get { return subtitlealignment; }
            set { subtitlealignment = value; overridesubtitleformat = true; }
        }
        private StringFormatFlags subtitleformatflags;
        public StringFormatFlags SubTitleFormatFlags
        {
            get { return subtitleformatflags; }
            set { subtitleformatflags = value; overridesubtitleformat = true; }
        }
        #endregion

        #region footer properties

        bool overridefooterformat = false;
        private String footer;
        public String Footer
        {
            get { return footer; }
            set { footer = value; }
        }
        private Font footerfont;
        public Font FooterFont
        {
            get { return footerfont; }
            set { footerfont = value; }
        }
        private Color footercolor;
        public Color FooterColor
        {
            get { return footercolor; }
            set { footercolor = value; }
        }
        private StringAlignment footeralignment;
        public StringAlignment FooterAlignment
        {
            get { return footeralignment; }
            set { footeralignment = value; overridefooterformat = true; }
        }
        private StringFormatFlags footerformatflags;
        public StringFormatFlags FooterFormatFlags
        {
            get { return footerformatflags; }
            set { footerformatflags = value; overridefooterformat = true; }
        }
        private float footerspacing;
        public float FooterSpacing
        {
            get { return footerspacing; }
            set { footerspacing = value; }
        }
        #endregion

        #region page number properties

        bool overridepagenumberformat = false;
        private bool pageno = true;
        public bool PageNumbers
        {
            get { return pageno; }
            set { pageno = value; }
        }
        private Font pagenofont;
        public Font PageNumberFont
        {
            get { return pagenofont; }
            set { pagenofont = value; }
        }
        private Color pagenocolor;
        public Color PageNumberColor
        {
            get { return pagenocolor; }
            set { pagenocolor = value; }
        }
        private StringAlignment pagenumberalignment;
        public StringAlignment PageNumberAlignment
        {
            get { return pagenumberalignment; }
            set { pagenumberalignment = value; overridepagenumberformat = true; }
        }
        private StringFormatFlags pagenumberformatflags;
        public StringFormatFlags PageNumberFormatFlags
        {
            get { return pagenumberformatflags; }
            set { pagenumberformatflags = value; overridepagenumberformat = true; }
        }
        private bool pagenumberontop = false;
        public bool PageNumberInHeader
        {
            get { return pagenumberontop; }
            set { pagenumberontop = value; }
        }
        private bool pagenumberonseparateline = false;
        public bool PageNumberOnSeparateLine
        {
            get { return pagenumberonseparateline; }
            set { pagenumberonseparateline = value; }
        }

        #endregion

        #region header cell properties

        bool overridecellheaderformat;
        private StringAlignment headercellalignment;
        public StringAlignment HeaderCellAlignment
        {
            get { return headercellalignment; }
            set { headercellalignment = value; overridecellheaderformat = true; }
        }
        private StringFormatFlags headercellformatflags;
        public StringFormatFlags HeaderCellFormatFlags
        {
            get { return headercellformatflags; }
            set { headercellformatflags = value; overridecellheaderformat = true; }
        }
        #endregion

        #region cell properties
        bool overridecellformat = true;
        private StringAlignment cellalignment;
        public StringAlignment CellAlignment
        {
            get { return cellalignment; }
            set { cellalignment = value; overridecellformat = true; }
        }
        private StringFormatFlags cellformatflags;
        public StringFormatFlags CellFormatFlags
        {
            get { return cellformatflags; }
            set { cellformatflags = value; overridecellformat = true; }
        }
        #endregion

        #region page level properties

        private Margins printmargins;
        public Margins PrintMargins
        {
            get { return printmargins; }
            set { printmargins = value; }
        }
        private bool porportionalcolumns = false;
        public bool PorportionalColumns
        {
            get { return porportionalcolumns = false; }
            set { porportionalcolumns = value; }
        }
        #endregion

        #endregion

        public DGVPrinter()
        {
            printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            printmargins = new Margins(60, 60, 160, 40);
            pagenofont = new Font("tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            pagenocolor = Color.Black;
            titlefont = new Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point);
            titlecolor = Color.Black;
            subtitlefont = new Font("Tahoma", 12, FontStyle.Bold, GraphicsUnit.Point);
            subtitlecolor = Color.Black;
            footerfont = new Font("Tahoma", 10, FontStyle.Bold, GraphicsUnit.Point);
            footercolor = Color.Black;
            titlealignment = StringAlignment.Center;
            titleformatflags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            subtitlealignment = StringAlignment.Center;
            subtitleformatflags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            footeralignment = StringAlignment.Center;
            footerformatflags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            pagenumberalignment = StringAlignment.Far;
            pagenumberformatflags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            headercellalignment = StringAlignment.Near;
            headercellformatflags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            cellalignment = StringAlignment.Near;
            cellformatflags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
        }
        public void PrintDataGridView(DataGridView dgv)
        {
            this.dgv = dgv;
            PrintDialog pd = new PrintDialog();
            pd.Document = printDoc;
            printDoc.DefaultPageSettings.Margins = printmargins;
            pd.AllowCurrentPage = true;
            pd.AllowSelection = true;
            pd.AllowSomePages = true;
            pd.AllowPrintToFile = false;
            if (DialogResult.OK == pd.ShowDialog())
            {
                SetupPrint(pd);

                printDoc.Print();
            }
        }
        public void PrintPreviewDataGridView(DataGridView dgv)
        {
            this.dgv = dgv;
            PrintDialog pd = new PrintDialog();
            pd.Document = printDoc;
            printDoc.DefaultPageSettings.Margins = printmargins;
            pd.AllowSelection = true;
            pd.AllowSomePages = true;
            pd.AllowCurrentPage = true;
            pd.AllowPrintToFile = false;
            if (DialogResult.OK == pd.ShowDialog())
            {
                SetupPrint(pd);
                PrintPreviewDialog ppdialog = new PrintPreviewDialog();
                ppdialog.Document = printDoc;
                ppdialog.WindowState = FormWindowState.Maximized;
                ppdialog.PrintPreviewControl.Zoom = 1.0;
                ppdialog.ShowDialog();
            }
        }
        void SetupPrint(PrintDialog pd)
        {
            if (printDoc.DefaultPageSettings.Landscape)
            {
                pageHeight = printDoc.DefaultPageSettings.PaperSize.Width;
                pageWidth = printDoc.DefaultPageSettings.PaperSize.Height;
            }
            else
            {
                pageHeight = printDoc.DefaultPageSettings.PaperSize.Height;
                pageWidth = printDoc.DefaultPageSettings.PaperSize.Width;
            }
            printmargins = printDoc.DefaultPageSettings.Margins;
            printWidth = pageWidth - printmargins.Left - printmargins.Right;
            printRange = pd.PrinterSettings.PrintRange;
            if (PrintRange.SomePages == printRange)
            {
                fromPage = pd.PrinterSettings.FromPage;
                toPage = pd.PrinterSettings.ToPage;
            }
            else
            {
                fromPage = 0;
                toPage = 2147483647;
            }
            if (PrintRange.Selection == printRange)
            {
                if (0 != dgv.SelectedRows.Count)
                {
                    rowstoprint = dgv.SelectedRows;
                    colstoprint = new List<object>(dgv.Columns.Count);
                    foreach (DataGridViewColumn col in dgv.Columns) if (col.Visible) colstoprint.Add(col);
                }
                else if (0 != dgv.SelectedColumns.Count)
                {
                    rowstoprint = dgv.Rows;
                    colstoprint = dgv.SelectedColumns;
                }
                else
                {
                    SortedList temprowstoprint = new SortedList(dgv.SelectedCells.Count);
                    SortedList tempcolstoprint = new SortedList(dgv.SelectedCells.Count);
                    int colindex, rowindex;
                    foreach (DataGridViewCell cell in dgv.SelectedCells)
                    {
                        colindex = cell.ColumnIndex;
                        rowindex = cell.RowIndex;

                        if (!temprowstoprint.Contains(rowindex))
                            temprowstoprint.Add(rowindex, dgv.Rows[rowindex]);

                        if (!tempcolstoprint.Contains(colindex))
                            tempcolstoprint.Add(colindex, dgv.Columns[colindex]);
                    }
                    rowstoprint = new List<object>(temprowstoprint.Count);
                    foreach (object item in temprowstoprint.Values) rowstoprint.Add(item);
                    colstoprint = new List<object>(tempcolstoprint.Count);
                    foreach (object item in tempcolstoprint.Values) colstoprint.Add(item);
                }
            }
            else if (PrintRange.CurrentPage == printRange)
            {
                rowstoprint = new List<object>(dgv.DisplayedRowCount(true));
                colstoprint = new List<object>(dgv.Columns.Count);
                for (int i = dgv.FirstDisplayedScrollingRowIndex;
                    i < dgv.FirstDisplayedScrollingRowIndex + dgv.DisplayedRowCount(true);
                    i++)
                {
                    DataGridViewRow row = dgv.Rows[i];
                    if (row.Visible) rowstoprint.Add(row);
                }
                colstoprint = new List<object>(dgv.Columns.Count);
                foreach (DataGridViewColumn col in dgv.Columns) if (col.Visible) colstoprint.Add(col);
            }
            else
            {
                rowstoprint = new List<object>(dgv.Rows.Count);
                foreach (DataGridViewRow row in dgv.Rows) if (row.Visible) rowstoprint.Add(row);
                colstoprint = new List<object>(dgv.Columns.Count);
                foreach (DataGridViewColumn col in dgv.Columns) if (col.Visible) colstoprint.Add(col);
            }
        }
        private static StringFormat managestringformat(StringAlignment alignment, StringFormatFlags flags,
            DataGridViewCellStyle controlstyle, bool overrideformat)
        {
            StringFormat format = new StringFormat();
            format.Trimming = StringTrimming.Word;
            format.Alignment = alignment;
            format.FormatFlags = flags;
            if (!overrideformat)
            {
                if (null != controlstyle)
                {
                    DataGridViewContentAlignment cellalign = controlstyle.Alignment;
                    if (cellalign.ToString().Contains("Middle")) format.Alignment = StringAlignment.Center;
                    else if (cellalign.ToString().Contains("Right")) format.Alignment = StringAlignment.Near;
                    else if (cellalign.ToString().Contains("Left")) format.Alignment = StringAlignment.Far;
                }
            }
            return format;
        }
        private void measureprintarea(Graphics g)
        {
            int i, j;
            rowheights = new List<float>(rowstoprint.Count);
            colwidths = new List<float>(colstoprint.Count);
            headerHeight = 0;
            footerHeight = 0;
            DataGridViewColumn col;
            DataGridViewRow row;
            Font headerfont = dgv.ColumnHeadersDefaultCellStyle.Font;
            if (null == headerfont)
                headerfont = dgv.DefaultCellStyle.Font;
            for (i = 0; i < colstoprint.Count; i++)
            {
                col = (DataGridViewColumn)colstoprint[i];
                SizeF size = g.MeasureString(col.HeaderText, headerfont);
                colwidths.Add(size.Width);
                colheaderheight = (colheaderheight < size.Height ? size.Height : colheaderheight);
            }
            if (pageno)
            {
                StringFormat format = managestringformat(pagenumberalignment, pagenumberformatflags,
                    dgv.DefaultCellStyle, overridetitleformat);
                pagenumberHeight = (g.MeasureString("Page", pagenofont, printWidth, format)).Height;
            }
            if (pagenumberontop && !pagenumberonseparateline)
            {
                headerHeight += pagenumberHeight;
            }
            if (!String.IsNullOrEmpty(title))
            {
                StringFormat format = managestringformat(titlealignment, titleformatflags,
                    null, overridetitleformat);
                headerHeight += (g.MeasureString(title, titlefont, printWidth, format)).Height;
            }
            if (!String.IsNullOrEmpty(subtitle))
            {
                StringFormat format = managestringformat(subtitlealignment, subtitleformatflags,
                    null, overridetitleformat);
                headerHeight += (g.MeasureString(subtitle, subtitlefont, printWidth, format)).Height;
            }
            headerHeight += colheaderheight;
            if (!String.IsNullOrEmpty(footer))
            {
                StringFormat format = managestringformat(footeralignment, footerformatflags,
                    null, overridefooterformat);
                footerHeight += (g.MeasureString(footer, footerfont, printWidth, format)).Height;
            }
            if (!pagenumberontop && !pagenumberonseparateline)
            {
                footerHeight += pagenumberHeight;
            }
            footerHeight += footerspacing;
            Font defaultfont = dgv.DefaultCellStyle.Font;
            Font cellfont;
            for (i = 0; i < rowstoprint.Count; i++)
            {
                row = (DataGridViewRow)rowstoprint[i];
                rowheights.Add(0);
                if (dgv.RowHeadersVisible)
                {
                    SizeF rhsize = g.MeasureString(row.HeaderCell.EditedFormattedValue.ToString(),
                        headerfont);
                    rowheaderwidth = (rowheaderwidth < rhsize.Width) ? rhsize.Width : rowheaderwidth;
                }
                for (j = 0; j < colstoprint.Count; j++)
                {
                    col = (DataGridViewColumn)colstoprint[j];

                    if (row.Cells[col.Name].HasStyle && (null != row.Cells[col.Name].Style.Font))
                        cellfont = row.Cells[col.Name].Style.Font;
                    else
                        cellfont = defaultfont;

                    SizeF size = g.MeasureString(row.Cells[col.Name].EditedFormattedValue.ToString(),
                        cellfont);
                    colwidths[j] = (colwidths[j] < size.Width ? size.Width : colwidths[j]);
                    rowheights[i] = (rowheights[i] < size.Height ? size.Height : rowheights[i]);
                }
            }
            coltotalwidth = rowheaderwidth;
            foreach (float w in colwidths)
                coltotalwidth += w;
            if (porportionalcolumns)
            {
                float ratio = (float)printWidth / (float)coltotalwidth;
                rowheaderwidth = rowheaderwidth * ratio;
                for (i = 0; i < colwidths.Count; i++)
                    colwidths[i] = colwidths[i] * ratio;
                coltotalwidth = printWidth;
            }
        }
        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            bool printthispage = false;
            float printpos = printmargins.Top;
            CurrentPage++;
            if ((CurrentPage >= fromPage) && (CurrentPage <= toPage))
                printthispage = true;
            if (1 == CurrentPage)
                measureprintarea(e.Graphics);
            while (!printthispage)
            {
                printpos = printmargins.Top + headerHeight;
                while (printpos < (pageHeight - footerHeight - printmargins.Top - printmargins.Bottom))
                {
                    lastrowprinted++;
                    printpos += rowheights[lastrowprinted];
                }
                CurrentPage++;
                if ((CurrentPage >= fromPage) && (CurrentPage <= toPage))
                    printthispage = true;
                if ((lastrowprinted >= rowstoprint.Count - 1) || (CurrentPage > toPage))
                {
                    e.HasMorePages = false;
                    return;
                }
            }
            printpos = printmargins.Top;
            if (pagenumberontop)
            {
                if (pageno)
                {
                    printsection(e.Graphics, ref printpos, "Page " + CurrentPage.ToString(CultureInfo.CurrentCulture),
                        pagenofont, pagenocolor, pagenumberalignment, pagenumberformatflags, overridepagenumberformat);
                    if (!pagenumberonseparateline)
                        printpos -= pagenumberHeight;
                }
            }
            if (flower_shop.imageadress.adress != @"\")
            {
                Image imgPerson = Image.FromFile(Application.StartupPath + flower_shop.imageadress.adress);
                e.Graphics.DrawImage(imgPerson, 350, 20, flower_shop.imageadress.ImageWidth, flower_shop.imageadress.ImageHeight);
            }
            if (!String.IsNullOrEmpty(title))
                printsection(e.Graphics, ref printpos, title, titlefont,
                  titlecolor, titlealignment, titleformatflags, overridetitleformat);
            if (!String.IsNullOrEmpty(subtitle))
                printsection(e.Graphics, ref printpos, subtitle, subtitlefont,
                    subtitlecolor, subtitlealignment, subtitleformatflags, overridesubtitleformat);
            printcolumnheadersRight(e.Graphics, ref printpos);
            while (printpos < (pageHeight - footerHeight - printmargins.Top - printmargins.Bottom))
            {
                lastrowprinted++;
                printrowRight(e.Graphics, ref printpos, (DataGridViewRow)(rowstoprint[lastrowprinted]));
                if (lastrowprinted >= rowstoprint.Count - 1)
                {
                    e.HasMorePages = false;
                    printfooter(e.Graphics, ref printpos);
                    lastrowprinted = -1;
                    CurrentPage = 0;
                    return;
                }
            }
            printfooter(e.Graphics, ref printpos);
            if (CurrentPage >= toPage)
            {
                e.HasMorePages = false;
                lastrowprinted = -1;
                CurrentPage = 0;
            }
            else
            {
                e.HasMorePages = true;
            }
            return;
        }
        private void printsection(Graphics g, ref float pos, string text,
            Font font, Color color, StringAlignment alignment, StringFormatFlags flags, bool useroverride)
        {
            StringFormat printformat = managestringformat(alignment, flags, null, useroverride);
            SizeF printsize = g.MeasureString(text, font, printWidth, printformat);
            RectangleF printarea = new RectangleF((float)printmargins.Left, pos, (float)printWidth,
               printsize.Height);
            g.DrawString(text, font, new SolidBrush(color), printarea, printformat);
            pos += printsize.Height;
        }
        private void printfooter(Graphics g, ref float pos)
        {
            pos = pageHeight - footerHeight - printmargins.Top - printmargins.Bottom;
            pos += footerspacing;
            printsection(g, ref pos, footer, footerfont,
                footercolor, footeralignment, footerformatflags, overridefooterformat);
            if (!pagenumberontop)
            {
                if (pageno)
                {
                    if (!pagenumberonseparateline)
                        pos = pos - pagenumberHeight;
                    printsection(g, ref pos, "Page " + CurrentPage.ToString(CultureInfo.CurrentCulture),
                        pagenofont, pagenocolor, pagenumberalignment, pagenumberformatflags, overridepagenumberformat);
                }
            }
        }
        private void printcolumnheaders(Graphics g, ref float pos)
        {
            float xcoord = printmargins.Left + rowheaderwidth;
            Color foreground = !(dgv.ColumnHeadersDefaultCellStyle.ForeColor.IsEmpty)
                ? dgv.ColumnHeadersDefaultCellStyle.ForeColor : dgv.DefaultCellStyle.ForeColor;
            Color background = !(dgv.ColumnHeadersDefaultCellStyle.BackColor.IsEmpty)
                ? dgv.ColumnHeadersDefaultCellStyle.BackColor : dgv.DefaultCellStyle.BackColor;
            Font font = (null != dgv.ColumnHeadersDefaultCellStyle.Font)
                ? dgv.ColumnHeadersDefaultCellStyle.Font : dgv.DefaultCellStyle.Font;
            RectangleF printarea = new RectangleF(xcoord, pos, coltotalwidth - rowheaderwidth,
                colheaderheight);
            SolidBrush forebrush = new SolidBrush(foreground);
            SolidBrush backbrush = new SolidBrush(background);
            Pen lines = new Pen(dgv.GridColor, 1);
            StringFormat format = managestringformat(headercellalignment, headercellformatflags,
                dgv.ColumnHeadersDefaultCellStyle, overridecellheaderformat);
            g.FillRectangle(backbrush, printarea);
            DataGridViewColumn col;
            for (int i = 0; i < colstoprint.Count; i++)
            {
                col = (DataGridViewColumn)colstoprint[i];
                RectangleF cellprintarea = new RectangleF(xcoord, pos, colwidths[i], colheaderheight);
                g.DrawString(col.HeaderText, font, forebrush, cellprintarea, format);
                if (dgv.ColumnHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
                    g.DrawRectangle(lines, xcoord, pos, colwidths[i], colheaderheight);
                xcoord += colwidths[i];
            }
            pos += colheaderheight;
        }
        private void printcolumnheadersRight(Graphics g, ref float pos)
        {
            float xcoord = printmargins.Right;
            Color foreground = !(dgv.ColumnHeadersDefaultCellStyle.ForeColor.IsEmpty)
                ? dgv.ColumnHeadersDefaultCellStyle.ForeColor : dgv.DefaultCellStyle.ForeColor;
            Color background = !(dgv.ColumnHeadersDefaultCellStyle.BackColor.IsEmpty)
                ? dgv.ColumnHeadersDefaultCellStyle.BackColor : dgv.DefaultCellStyle.BackColor;
            Font font = (null != dgv.ColumnHeadersDefaultCellStyle.Font)
                ? dgv.ColumnHeadersDefaultCellStyle.Font : dgv.DefaultCellStyle.Font;
            RectangleF printarea = new RectangleF(pageWidth - xcoord - (coltotalwidth - rowheaderwidth), pos, coltotalwidth - rowheaderwidth,
                colheaderheight);
            SolidBrush forebrush = new SolidBrush(foreground);
            SolidBrush backbrush = new SolidBrush(background);
            Pen lines = new Pen(dgv.GridColor, 1);
            StringFormat format = managestringformat(headercellalignment, headercellformatflags,
                dgv.ColumnHeadersDefaultCellStyle, overridecellheaderformat);
            g.FillRectangle(backbrush, printarea);
            DataGridViewColumn col;
            for (int i = 0; i < colstoprint.Count; i++)
            {
                col = (DataGridViewColumn)colstoprint[i];
                RectangleF cellprintarea = new RectangleF(pageWidth - xcoord - colwidths[i], pos, colwidths[i], colheaderheight);
                g.DrawString(col.HeaderText, font, forebrush, cellprintarea, format);
                if (dgv.ColumnHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
                    g.DrawRectangle(lines, pageWidth - xcoord - colwidths[i], pos, colwidths[i], colheaderheight);

                xcoord += colwidths[i];
            }
            pos += colheaderheight;
        }
        private void printrow(Graphics g, ref float pos, DataGridViewRow row)
        {
            float xcoord = printmargins.Left;
            Color foreground = !(row.DefaultCellStyle.ForeColor.IsEmpty)
                ? row.DefaultCellStyle.ForeColor : dgv.DefaultCellStyle.ForeColor;
            Color background = !(row.DefaultCellStyle.BackColor.IsEmpty)
                ? row.DefaultCellStyle.BackColor : dgv.DefaultCellStyle.BackColor;
            Font font = (null != row.DefaultCellStyle.Font)
                ? row.DefaultCellStyle.Font : dgv.DefaultCellStyle.Font;
            RectangleF printarea = new RectangleF(xcoord, pos, coltotalwidth, rowheights[lastrowprinted]);
            SolidBrush forebrush = new SolidBrush(foreground);
            SolidBrush backbrush = new SolidBrush(background);
            Pen lines = new Pen(dgv.GridColor, 1);
            StringFormat format = managestringformat(cellalignment, cellformatflags, row.DefaultCellStyle,
                overridecellformat);
            g.FillRectangle(backbrush, printarea);
            if (dgv.RowHeadersVisible)
            {
                StringFormat rowheaderformat = managestringformat(headercellalignment,
                    headercellformatflags, row.DefaultCellStyle, overridecellheaderformat);
                RectangleF headercellprintarea = new RectangleF(xcoord, pos, rowheaderwidth, rowheights[lastrowprinted]);
                g.DrawString(row.HeaderCell.EditedFormattedValue.ToString(),
                    font, forebrush, headercellprintarea, rowheaderformat);
                if (dgv.RowHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
                    g.DrawRectangle(lines, xcoord, pos, rowheaderwidth, rowheights[lastrowprinted]);
                xcoord += rowheaderwidth;
            }
            DataGridViewColumn col;
            for (int i = 0; i < colstoprint.Count; i++)
            {
                col = (DataGridViewColumn)colstoprint[i];
                RectangleF cellprintarea = new RectangleF(xcoord, pos, colwidths[i], rowheights[lastrowprinted]);
                g.DrawString(row.Cells[col.Index].EditedFormattedValue.ToString(),
                    font, forebrush, cellprintarea, format);
                if (dgv.BorderStyle != BorderStyle.None)
                    g.DrawRectangle(lines, xcoord, pos, colwidths[i], rowheights[lastrowprinted]);
                xcoord += colwidths[i];
            }
            pos += rowheights[lastrowprinted];
        }
        private void printrowRight(Graphics g, ref float pos, DataGridViewRow row)
        {
            float xcoord = printmargins.Right;
            Color foreground = !(row.DefaultCellStyle.ForeColor.IsEmpty)
                ? row.DefaultCellStyle.ForeColor : dgv.DefaultCellStyle.ForeColor;
            Color background = !(row.DefaultCellStyle.BackColor.IsEmpty)
                ? row.DefaultCellStyle.BackColor : dgv.DefaultCellStyle.BackColor;
            Font font = (null != row.DefaultCellStyle.Font)
                ? row.DefaultCellStyle.Font : dgv.DefaultCellStyle.Font;
            RectangleF printarea = new RectangleF(pageWidth - xcoord - coltotalwidth, pos, coltotalwidth, rowheights[lastrowprinted]);
            SolidBrush forebrush = new SolidBrush(foreground);
            SolidBrush backbrush = new SolidBrush(background);
            Pen lines = new Pen(dgv.GridColor, 1);
            StringFormat format = managestringformat(cellalignment, cellformatflags, row.DefaultCellStyle,
                overridecellformat);
            g.FillRectangle(backbrush, printarea);
            if (dgv.RowHeadersVisible)
            {
                StringFormat rowheaderformat = managestringformat(headercellalignment,
                    headercellformatflags, row.DefaultCellStyle, overridecellheaderformat);
                RectangleF headercellprintarea = new RectangleF(pageWidth - xcoord - rowheaderwidth, pos, rowheaderwidth, rowheights[lastrowprinted]);
                g.DrawString(row.HeaderCell.EditedFormattedValue.ToString(),
                    font, forebrush, headercellprintarea, rowheaderformat);
                if (dgv.RowHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
                    g.DrawRectangle(lines, pageWidth - xcoord - rowheaderwidth, pos, rowheaderwidth, rowheights[lastrowprinted]);
                xcoord += rowheaderwidth;
            }
            DataGridViewColumn col;
            for (int i = 0; i < colstoprint.Count; i++)
            {
                col = (DataGridViewColumn)colstoprint[i];
                RectangleF cellprintarea = new RectangleF(pageWidth - xcoord - colwidths[i], pos, colwidths[i], rowheights[lastrowprinted]);
                g.DrawString(row.Cells[col.Index].EditedFormattedValue.ToString(),
                    font, forebrush, cellprintarea, format);
                if (dgv.BorderStyle != BorderStyle.None)
                    g.DrawRectangle(lines, pageWidth - xcoord - colwidths[i], pos, colwidths[i], rowheights[lastrowprinted]);
                xcoord += colwidths[i];
            }
            pos += rowheights[lastrowprinted];
        }
    }*/
}
