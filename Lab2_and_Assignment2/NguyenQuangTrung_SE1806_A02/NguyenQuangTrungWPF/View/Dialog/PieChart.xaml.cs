using FUHotelManageLibrary.dal;
using FUHotelManageLibrary.Model;
using FUHotelManageLibrary.Repository;
using FUHotelManageLibrary.Services;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NguyenQuangTrungWPF.View.Dialog
{
    /// <summary>
    /// Interaction logic for PieChart.xaml
    /// </summary>
    public partial class PieChart : Window
    {
        private BookingDetailService _bookingDetailService;

        public PieChart()
        {
            InitializeComponent();
            var bookingDetailContext = new DBContext();
            var bookingDetailRepo = new BookingDetailRepository(bookingDetailContext);
            _bookingDetailService = new BookingDetailService(bookingDetailRepo);

            GetPlotView();
        }

        private void GetPlotView()
        {
            string title = "Booking Details";
            IEnumerable<BookingDetail> bookingDetails = _bookingDetailService.GetAlls();
            Dictionary<int, decimal> rooms = new Dictionary<int, decimal>();

            foreach (var booking in bookingDetails)
            {
                if (rooms.ContainsKey(booking.RoomID))
                {
                    rooms[booking.RoomID] += booking.ActualPrice;
                }
                else
                {
                    rooms[booking.RoomID] = booking.RoomID;
                }
            }


            PlotModel plotModel = new PlotModel { Title = title };


            var series = new PieSeries
            {
                StrokeThickness = 2.0,
                InsideLabelPosition = 0.5,
                AngleSpan = 360,
                StartAngle = 0,
                FontSize = 15,
                OutsideLabelFormat = "{2:0} %",
                TickHorizontalLength = 5,
                TickRadialLength = 5,
                TickDistance = 1,
                TickLabelDistance = 1,
            };


            foreach (var bookingDetail in rooms)
            {
                series.Slices.Add(new PieSlice(bookingDetail.Key.ToString(), (Double)bookingDetail.Value) { IsExploded = true });
            }

            plotModel.Series.Add(series);

            plot.Model = plotModel;
        }
    }
}
