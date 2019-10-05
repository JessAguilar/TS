using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HorariosTI
{
    internal static class PDFToObject
    {
        internal static string GetPDFContent()
        {
            PdfReader Pdfreader = new PdfReader("Horarios Sistemas II-2019.pdf");
            string Pdfcontent = string.Empty;
            for (int pagenumber = 1; pagenumber <= Pdfreader.NumberOfPages; pagenumber++)
            {
                Pdfcontent += PdfTextExtractor.GetTextFromPage(Pdfreader, pagenumber);
            }
            Pdfreader.Close();
            return Pdfcontent;
        }
        internal static List<Subject> GetSubjects(this List<Subject> subjectsList)
        {
            string SubjectDataWhitOutId;
            Match SubjectMatch;
            var SplitForIntro = GetPDFContent().Split('\n');
            Regex RegularExpressionWhitOutLetters = new Regex(@"\d+");
            foreach (var item in SplitForIntro)
            {
                SubjectMatch = RegularExpressionWhitOutLetters.Match(item);
                if (SubjectMatch.Success)
                {
                    if (int.Parse(SubjectMatch.Value) > 411702)
                    {
                        SubjectDataWhitOutId = item.Replace(SubjectMatch.Value, "");
                        var splitGuion = SubjectDataWhitOutId.Split('-');
                        string text1 = splitGuion[0];
                        string text2 = splitGuion[1];
                        var splitspace = text1.Split(' ');
                        string nameSubject = "";
                        for (int i = 0; i < splitspace.Length - 3; i++)
                        {
                            nameSubject += splitspace[i] + " ";
                        }
                        string horai = "";
                        string minui = "";
                        string horaf = "";
                        string minuf = "";
                        if (splitspace[splitspace.Length - 1].Length > 3)
                        {
                            horai = splitspace[splitspace.Length - 1][0].ToString() +
                                splitspace[splitspace.Length - 1][1].ToString();
                            minui = splitspace[splitspace.Length - 1][2].ToString() +
                                splitspace[splitspace.Length - 1][3].ToString();
                        }
                        else
                        {
                            horai = splitspace[splitspace.Length - 1][0].ToString();
                            minui = splitspace[splitspace.Length - 1][1].ToString() +
                                splitspace[splitspace.Length - 1][2].ToString();
                        }
                        
                        var splitbracket = text2.Split('(');
                        if (splitbracket[0].Length > 3)
                        {
                            horaf = splitbracket[0][0].ToString() + splitbracket[0][1].ToString();
                            minuf = splitbracket[0][2].ToString() + splitbracket[0][3].ToString();
                        }
                        else
                        {
                            horaf = splitbracket[0][0].ToString();
                            minuf = splitbracket[0][1].ToString() + splitbracket[0][2].ToString();
                        }
                        Subject subject = new Subject(int.Parse(SubjectMatch.Value), nameSubject.Trim(), 
                            splitspace[splitspace.Length - 3], int.Parse(horai), int.Parse(minui),
                            int.Parse(horaf), int.Parse(minuf), splitspace[splitspace.Length - 2]);
                        subjectsList.Add(subject);
                    }
                }
            }
            return subjectsList;
        }
    }
}
