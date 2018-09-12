using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Study.LogUtil;

namespace Study.ExcelUtil
{
    public class ExcelManager : IExcelUtil, IDisposable
    {
        private bool disposed;
        public string FileName { get; set; }
        public IWorkbook Workbook { get; set; }
        public FileStream Fs { get; set; }

        public int DataTableToExcel(DataTable data, string sheetName, bool isColumnWritten)
        {
            int i = 0;
            int j = 0;
            int count = 0;
            ISheet sheet = null;

            Fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            if (FileName.IndexOf(".xlsx") > 0) // 2007版本
                Workbook = new XSSFWorkbook();
            else if (FileName.IndexOf(".xls") > 0) // 2003版本
                Workbook = new HSSFWorkbook();

            try
            {
                if (Workbook != null)
                {
                    sheet = Workbook.CreateSheet();
                }
                else
                {
                    return -1;
                }

                if (isColumnWritten == true) //写入DataTable的列名
                {
                    IRow row = sheet.CreateRow(0);
                    for (j = 0; j < data.Columns.Count; ++j)
                    {
                        row.CreateCell(j).SetCellValue(data.Columns[j].ColumnName);
                    }
                    count = 1;
                }
                else
                {
                    count = 0;
                }

                for (i = 0; i < data.Rows.Count; ++i)
                {
                    IRow row = sheet.CreateRow(count);
                    for (j = 0; j < data.Columns.Count; ++j)
                    {
                        row.CreateCell(j).SetCellValue(data.Rows[i][j].ToString());
                    }
                    ++count;
                }
                Workbook.Write(Fs); //写入到excel
                return count;
            }
            catch (Exception ex)
            {
                Log4Helper.Error(typeof(ExcelManager), ex.Message, ex);
                return -1;
            }
        }

        public DataTable ExcelToDataTable(string sheetName, bool isFirstRowColumn)
        {
            ISheet sheet = null;
            DataTable data = new DataTable();
            int startRow = 0;
            try
            {
                Fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                if (FileName.IndexOf(".xlsx") > 0) // 2007版本
                    Workbook = new XSSFWorkbook(Fs);
                else if (FileName.IndexOf(".xls") > 0) // 2003版本
                    Workbook = new HSSFWorkbook(Fs);

                if (sheetName != null)
                {
                    sheet = Workbook.GetSheet(sheetName);
                    if (sheet == null) //如果没有找到指定的sheetName对应的sheet，则尝试获取第一个sheet
                    {
                        sheet = Workbook.GetSheetAt(0);
                    }
                }
                else
                {
                    sheet = Workbook.GetSheetAt(0);
                }
                if (sheet != null)
                {
                    IRow firstRow = sheet.GetRow(0);
                    int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数

                    if (isFirstRowColumn)
                    {
                        for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                        {
                            ICell cell = firstRow.GetCell(i);
                            if (cell != null)
                            {
                                string cellValue = cell.StringCellValue;
                                if (cellValue != null)
                                {
                                    DataColumn column = new DataColumn(cellValue);
                                    data.Columns.Add(column);
                                }
                            }
                        }
                        startRow = sheet.FirstRowNum + 1;
                    }
                    else
                    {
                        startRow = sheet.FirstRowNum;
                    }

                    //最后一列的标号
                    int rowCount = sheet.LastRowNum;
                    for (int i = startRow; i <= rowCount; ++i)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue; //没有数据的行默认是null　　　　　　　

                        DataRow dataRow = data.NewRow();
                        for (int j = row.FirstCellNum; j < cellCount; ++j)
                        {
                            if (row.GetCell(j) != null) //同理，没有数据的单元格都默认是null
                                dataRow[j] = row.GetCell(j).ToString();
                        }
                        data.Rows.Add(dataRow);
                    }
                }

                return data;
            }
            catch (Exception ex)
            {
                Log4Helper.Error(typeof(ExcelManager), ex.Message, ex);
                return null;
            }
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (Fs != null)
                        Fs.Close();
                }

                Fs = null;
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
