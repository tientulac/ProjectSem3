using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebApplication1.Models.InputModel;

namespace WebApplication1.Controllers
{
    public class ExcelLayer
    {
        //--------------------------------------------------EXCEL PARTICIPANT-------------------------------------//
        public byte[] ExportParticipant(List<RequestParticipant> m)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            try
            {
                FileInfo newFile = new FileInfo("Participant");
                if (newFile.Exists)
                {
                    newFile.Delete();
                    newFile = new FileInfo("Participant");
                }
                using (var package = new ExcelPackage(new FileInfo("Participant.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách");
                    worksheet.Column(1).Width = 10;
                    worksheet.Column(2).Width = 20;
                    worksheet.Column(3).Width = 40;
                    worksheet.Column(4).Width = 30;
                    worksheet.Column(5).Width = 30;
                    worksheet.Column(6).Width = 20;
                    worksheet.Column(7).Width = 20;
                    worksheet.Column(7).Width = 30;

                    var rows = 4;

                    using (var tieu_de = worksheet.Cells[1, 1, 3, 8])
                    {
                        tieu_de.Value = "DANH SÁCH NGƯỜI THAM GIA";
                        tieu_de.Merge = true;
                        tieu_de.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        tieu_de.Style.Font.Bold = true;
                        tieu_de.Style.Font.Name = "Times New Roman";
                        tieu_de.Style.Font.Size = 13;
                    }
                    using (var tieu_de = worksheet.Cells[rows, 1])
                    {
                        tieu_de.Value = "STT";
                        tieu_de.Merge = true;
                        tieu_de.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        tieu_de.Style.Font.Bold = true;
                        tieu_de.Style.Font.Name = "Times New Roman";
                        tieu_de.Style.Font.Size = 13;
                    }
                    using (var tieu_de = worksheet.Cells[rows, 2])
                    {
                        tieu_de.Value = "Họ tên";
                        tieu_de.Merge = true;
                        tieu_de.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        tieu_de.Style.Font.Bold = true;
                        tieu_de.Style.Font.Name = "Times New Roman";
                        tieu_de.Style.Font.Size = 13;
                    }
                    using (var tieu_de = worksheet.Cells[rows, 3])
                    {
                        tieu_de.Value = "Số điện thoại";
                        tieu_de.Merge = true;
                        tieu_de.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        tieu_de.Style.Font.Bold = true;
                        tieu_de.Style.Font.Name = "Times New Roman";
                        tieu_de.Style.Font.Size = 13;
                    }
                    using (var tieu_de = worksheet.Cells[rows, 4])
                    {
                        tieu_de.Value = "Địa chỉ";
                        tieu_de.Merge = true;
                        tieu_de.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        tieu_de.Style.Font.Bold = true;
                        tieu_de.Style.Font.Name = "Times New Roman";
                        tieu_de.Style.Font.Size = 13;
                    }
                    using (var tieu_de = worksheet.Cells[rows, 5])
                    {
                        tieu_de.Value = "Email";
                        tieu_de.Merge = true;
                        tieu_de.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        tieu_de.Style.Font.Bold = true;
                        tieu_de.Style.Font.Name = "Times New Roman";
                        tieu_de.Style.Font.Size = 13;
                    }
                    using (var tieu_de = worksheet.Cells[rows, 6])
                    {
                        tieu_de.Value = "Giới tính";
                        tieu_de.Merge = true;
                        tieu_de.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        tieu_de.Style.Font.Bold = true;
                        tieu_de.Style.Font.Name = "Times New Roman";
                        tieu_de.Style.Font.Size = 13;
                    }
                    using (var tieu_de = worksheet.Cells[rows, 7])
                    {
                        tieu_de.Value = "Ngày sinh";
                        tieu_de.Merge = true;
                        tieu_de.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        tieu_de.Style.Font.Bold = true;
                        tieu_de.Style.Font.Name = "Times New Roman";
                        tieu_de.Style.Font.Size = 13;
                    }
                    using (var tieu_de = worksheet.Cells[rows, 8])
                    {
                        tieu_de.Value = "Tổng số tiền donate";
                        tieu_de.Merge = true;
                        tieu_de.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        tieu_de.Style.WrapText = true;
                        tieu_de.Style.Font.Bold = true;
                        tieu_de.Style.Font.Name = "Times New Roman";
                        tieu_de.Style.Font.Size = 13;
                    }

                    rows += 1;
                    for (var i = 0; i < m.Count(); i++)
                    {
                        worksheet.Cells[i + rows, 1].Value = i + 1;
                        worksheet.Cells[i + rows, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                        worksheet.Cells[i + rows, 2].Value = m[i].ParticipantName;
                        worksheet.Cells[i + rows, 2].Style.WrapText = true;

                        worksheet.Cells[i + rows, 3].Value = m[i].Phone;
                        worksheet.Cells[i + rows, 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[i + rows, 3].Style.WrapText = true;

                        worksheet.Cells[i + rows, 4].Value = m[i].Address;
                        worksheet.Cells[i + rows, 4].Style.WrapText = true;

                        worksheet.Cells[i + rows, 5].Value = m[i].Email;
                        worksheet.Cells[i + rows, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                        worksheet.Cells[i + rows, 6].Value = m[i].GenderName;
                        worksheet.Cells[i + rows, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                        worksheet.Cells[i + rows, 7].Value = m[i].Birth.ToString().Substring(0, 10);
                        worksheet.Cells[i + rows, 7].Style.Numberformat.Format = "dd-mm-yyyy";

                        worksheet.Cells[i + rows, 8].Value = m[i].DonateAmount;
                        worksheet.Cells[i + rows, 8].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }
                    using (var baocao = worksheet.Cells[2, 1, m.Count + 4, 8])
                    {
                        try
                        {
                            baocao.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                            baocao.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                            baocao.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                            baocao.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }

                    return package.GetAsByteArray();
                }
            }
            catch (Exception ex)
            {
                string mes = m == null ? "DataIsNull" : "CountData = " + m.Count();
                return ExportParticipant(m);
            }
        }
    }
}