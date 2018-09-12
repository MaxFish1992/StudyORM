using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.ExcelUtil
{
    /// <summary>
    /// 说明：Excel表格处理接口
    /// 作者：huangwei
    /// 时间：2018-9-12
    /// </summary>
    public partial interface IExcelUtil
    {
        /// <summary>
        /// 文件完整路径
        /// </summary>
        string FileName { get; set; }
        /// <summary>
        /// 工作表
        /// </summary>
        IWorkbook Workbook { get; set; }
        /// <summary>
        /// 文件流
        /// </summary>
        FileStream Fs { get; set; }
        /// <summary>
        /// 将Excel导入DataTable
        /// </summary>
        /// <param name="sheetName">工作表名称</param>
        /// <param name="isFirstRowColumn">第一行是否为表头</param>
        /// <returns></returns>
        DataTable ExcelToDataTable(string sheetName, bool isFirstRowColumn);
        /// <summary>
        /// 将DataTable导入Excel中
        /// </summary>
        /// <param name="data">DataTable</param>
        /// <param name="sheetName">工作表名称</param>
        /// <param name="isColumnWritten">是否写入表头</param>
        /// <returns></returns>
        int DataTableToExcel(DataTable data, string sheetName, bool isColumnWritten);
    }
}
