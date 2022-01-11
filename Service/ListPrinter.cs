using RejAndOlej.Enums;
using RejAndOlej.Models;
using RejAndOlej.Views.TableViews;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejAndOlej.Service
{
    class ListPrinter
    {

        private ICollection<FleetMainTableView> _dataSourceFleet;
        private ICollection<BusMakersMainTableView> _dataSourceBusMakers;
        private ICollection<BusModelsMainTableView> _dataSourceBusModels;
        private ICollection<OilChecksMainTableView> _dataSourceOilChecks;
        private ICollection<RegistrationChecksMainTableView> _dataSourceRegistrationChecks;
        private ICollection<UsersMainTableView> _dataSourceUsers;

        private string _tableHeader = "";

        private EnModels.Models _entityType;
        public ListPrinter(ICollection<BusMakersMainTableView> dataList)
        {
            _dataSourceBusMakers = dataList;

            _entityType = EnModels.Models.BusMakers;

            if (_dataSourceBusMakers != null && _dataSourceBusMakers.Count != 0)
            {
                _tableHeader = "Nazwa producenta".PadRight(20, ' ') + "Kraj pochodzenia".PadRight(20, ' ');
            }
        }

        public ListPrinter(ICollection<BusModelsMainTableView> dataList)
        {
            _dataSourceBusModels = dataList;

            _entityType = EnModels.Models.BusModels;

            if (_dataSourceBusModels != null && _dataSourceBusModels.Count != 0)
            {
                _tableHeader = "Model Pojazdu".PadRight(35, ' ') + "Przedział przeglądu olejowego".PadRight(35, ' ') + "Przedział przeglądu rejestracyjnego".PadRight(30, ' ');
            }
        }

        public ListPrinter(ICollection<FleetMainTableView> datalist)
        {
            _dataSourceFleet = datalist;

            _entityType = EnModels.Models.BusFleet;

            if (_dataSourceFleet != null && _dataSourceFleet.Count != 0)
            {
                _tableHeader = "Model Pojazdu".PadRight(30, ' ') + "Numer Rejestracyjny".PadRight(25, ' ') + "Numer Taborowy".PadRight(20, ' ') + "Przebieg".PadRight(10, ' ');
            }
        }

        public ListPrinter(ICollection<OilChecksMainTableView> datalist)
        {
            _dataSourceOilChecks = datalist;

            _entityType = EnModels.Models.OilChecks;

            if (_dataSourceOilChecks != null && _dataSourceOilChecks.Count != 0)
            {
                _tableHeader = "Data Przeglądu".PadRight(20, ' ') + "Przebieg na moment przeglądu".PadRight(30, ' ');
            }
        }


        public ListPrinter(ICollection<RegistrationChecksMainTableView> datalist)
        {
            _dataSourceRegistrationChecks = datalist;

            _entityType = EnModels.Models.RegistrationChecks;

            if (_dataSourceRegistrationChecks != null && _dataSourceRegistrationChecks.Count != 0)
            {
                _tableHeader = "Data Przeglądu".PadRight(20, ' ') + "Przebieg na moment przeglądu".PadRight(30, ' ');
            }
        }

        public ListPrinter(ICollection<UsersMainTableView> dataList)
        {
            _dataSourceUsers = dataList;

            _entityType = EnModels.Models.Users;

            if (_dataSourceUsers != null && _dataSourceUsers.Count != 0)
            {
                _tableHeader = "Imię".PadRight(15, ' ') + "Nazwisko".PadRight(20, ' ') + "Stanowisko".PadRight(20, ' ');
            }
        }


        public void Print()
        {
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += (s, e) => PrintPage(s, e);

            PrintPreviewDialog printPreview = new PrintPreviewDialog();

            printPreview.Document = printDocument;

            if (printPreview.ShowDialog() == DialogResult.OK)
            {
                PrinterSettings settings = new PrinterSettings();
                printDocument.PrinterSettings = settings;
                var a4 = settings.PaperSizes.Cast<PaperSize>().First(size => size.Kind == PaperKind.A4);
                printDocument.DefaultPageSettings.PaperSize = a4;
                printDocument.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            float y = 120;
            switch (_entityType)
            {
                case EnModels.Models.BusMakers:
                    e.Graphics.DrawString("Lista Producentów", new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(220, 100));

                    if (_dataSourceBusMakers == null || _dataSourceBusMakers.Count == 0)
                        return;

                    e.Graphics.DrawString(_tableHeader, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new PointF(80, y += 30));

                    foreach (var record in _dataSourceBusMakers)
                    {
                        string newLine = record.BusMakerName.PadRight(20, ' ') + record.BusMakerNation.PadRight(20, ' ');

                        e.Graphics.DrawString(newLine, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new PointF(80, y += 30));
                    }
                    break;

                case EnModels.Models.BusModels:
                    e.Graphics.DrawString("Modele autobusów", new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(220, 100));

                    if (_dataSourceBusModels == null || _dataSourceBusModels.Count == 0)
                        return;

                    e.Graphics.DrawString(_tableHeader, new Font("Times New Roman", 12, FontStyle.Underline), Brushes.Black, new PointF(80, y += 30));

                    foreach (var record in _dataSourceBusModels)
                    {
                        string newLine = (record.BusMakerName + ' ' + record.ModelName).PadRight(30, ' ') + record.DefaultKmToCheck.ToString().PadLeft(40, ' ') +
                            record.DefaultDaysToCheck.ToString().PadLeft(30, ' ');

                        e.Graphics.DrawString(newLine, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new PointF(80, y += 30));
                    }
                    break;

                case EnModels.Models.BusFleet:
                    e.Graphics.DrawString("Lista pojazdów", new Font("Times New Romans", 16, FontStyle.Bold), Brushes.Black, new PointF(220, 100));

                    if (_dataSourceFleet == null || _dataSourceFleet.Count == 0)
                        return;

                    e.Graphics.DrawString(_tableHeader, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new PointF(80, y += 30));

                    foreach (FleetMainTableView record in _dataSourceFleet)
                    {
                        string newLine = record.BusModel.PadRight(30, ' ') + record.RegistrationNumber.PadRight(25, ' ') + record.RaceNumber.PadRight(20, ' ')
                            + record.Mileage.ToString().PadRight(10, ' ');

                        e.Graphics.DrawString(newLine, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new PointF(80, y += 30));
                    }
                    break;

                case EnModels.Models.OilChecks:

                    if (_dataSourceOilChecks == null || _dataSourceOilChecks.Count == 0)
                        return;

                    e.Graphics.DrawString("Lista przeglądów olejowych pojazdu: " + _dataSourceOilChecks.First().NumerRejestracyjny, new Font("Times New Romans", 16, FontStyle.Bold), Brushes.Black, new PointF(150, 100));

                    e.Graphics.DrawString(_tableHeader, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new PointF(80, y += 30));

                    foreach (var record in _dataSourceOilChecks)
                    {
                        string newLine = record.DataPrzegladu.Value.Date.ToString().PadRight(30, ' ') + record.PrzebiegNaMomentPrzegladu.PadRight(25, ' ');

                        e.Graphics.DrawString(newLine, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new PointF(80, y += 30));
                    }
                    break;

                case EnModels.Models.RegistrationChecks:
                    if (_dataSourceRegistrationChecks == null || _dataSourceRegistrationChecks.Count == 0)
                        return;

                    e.Graphics.DrawString("Lista przeglądów olejowych pojazdu: " + _dataSourceRegistrationChecks.First().NumerRejestracyjny, new Font("Times New Romans", 16, FontStyle.Bold), Brushes.Black, new PointF(150, 100));

                    e.Graphics.DrawString(_tableHeader, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new PointF(80, y += 30));

                    foreach (var record in _dataSourceRegistrationChecks)
                    {
                        string newLine = record.DataPrzegladu.Value.Date.ToString().PadRight(30, ' ') + record.PrzebiegNaMomentPrzegladu.PadRight(25, ' ');

                        e.Graphics.DrawString(newLine, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new PointF(80, y += 30));
                    }
                    break;

                case EnModels.Models.Users:
                    if (_dataSourceUsers == null || _dataSourceUsers.Count == 0)
                        return;

                    e.Graphics.DrawString("Lista użytkowników", new Font("Times New Romans", 16, FontStyle.Bold), Brushes.Black, new PointF(150, 100));

                    e.Graphics.DrawString(_tableHeader, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new PointF(80, y += 30));

                    foreach (var record in _dataSourceUsers)
                    {
                        string newLine = record.Name.PadRight(15, ' ') + record.Surname.PadRight(20, ' ');// + record.Position.PadRight(20, ' ');

                        e.Graphics.DrawString(newLine, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new PointF(80, y += 30));
                    }
                    break;
            }

        }
    }
}
