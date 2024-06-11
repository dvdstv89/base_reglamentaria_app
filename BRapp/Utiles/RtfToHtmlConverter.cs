using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using RtfPipe;
using Application = Microsoft.Office.Interop.Word.Application;

namespace BRapp.Utiles
{
    public static class RtfToHtmlConverter
    {
        public static string Convert(string rtfContent)
        {
            string html = GetHtml(rtfContent);         
            return html;
        }

        private static string GetHtml(string rtfContent)
        {
            string htmlCode = "";
            string tempRtfFile = null;
            string tempHtmlFile = null;

            var thread = new Thread(() =>
            {
                Application applicationObject = null;
                Microsoft.Office.Interop.Word.Document documentObject = null;

                try
                {
                    applicationObject = new Application
                    {
                        DisplayAlerts = WdAlertLevel.wdAlertsNone
                    };

                    // Create a temporary RTF file
                    tempRtfFile = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".rtf");
                    File.WriteAllText(tempRtfFile, rtfContent);

                    object fileName = tempRtfFile;
                    object missing = Type.Missing;
                    object False = false;

                    documentObject = applicationObject.Documents.Open(ref fileName, ref missing, ref missing, ref missing,
                                                                      ref missing, ref missing, ref missing, ref missing,
                                                                      ref missing, ref missing, ref missing, ref False,
                                                                      ref missing, ref missing, ref missing, ref missing);

                    // Create a temporary HTML file
                    tempHtmlFile = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".html");
                    object fileFormat = WdSaveFormat.wdFormatHTML;

                    if (File.Exists(tempHtmlFile))
                    {
                        File.Delete(tempHtmlFile);
                    }

                    documentObject.SaveAs2(tempHtmlFile, fileFormat);

                    documentObject.Close(false);
                    Marshal.ReleaseComObject(documentObject);
                    documentObject = null;

                    applicationObject.Quit();
                    Marshal.ReleaseComObject(applicationObject);
                    applicationObject = null;

                    if (File.Exists(tempHtmlFile))
                    {
                        using (WebClient client = new WebClient())
                        {
                            htmlCode = client.DownloadString(tempHtmlFile);
                        }

                        File.Delete(tempHtmlFile);
                    }

                    // Delete the temporary RTF file
                    File.Delete(tempRtfFile);
                }
                catch (Exception ex)
                {
                    // Log the exception if necessary
                    Console.WriteLine(ex.Message);
                    htmlCode = "";
                }
                finally
                {
                    if (documentObject != null)
                    {
                        documentObject.Close(false);
                        Marshal.ReleaseComObject(documentObject);
                    }

                    if (applicationObject != null)
                    {
                        applicationObject.Quit();
                        Marshal.ReleaseComObject(applicationObject);
                    }

                    // Ensure the temporary RTF file is deleted
                    if (tempRtfFile != null && File.Exists(tempRtfFile))
                    {
                        try
                        {
                            File.Delete(tempRtfFile);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Failed to delete temporary RTF file: {ex.Message}");
                        }
                    }

                    // Ensure the temporary HTML file is deleted
                    if (tempHtmlFile != null && File.Exists(tempHtmlFile))
                    {
                        try
                        {
                            File.Delete(tempHtmlFile);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Failed to delete temporary HTML file: {ex.Message}");
                        }
                    }
                }
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            return htmlCode;
        }
    }
}
