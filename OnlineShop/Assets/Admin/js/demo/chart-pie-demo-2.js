// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = 'Nunito, -apple-system, system-ui, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue", Arial, sans-serif';
Chart.defaults.global.defaultFontColor = '#858796';

// Pie Chart Example
var ctx = document.getElementById("myPieChart2");
var myPieChart = new Chart(ctx, {
    type: 'doughnut',
    data: {
        labels: ["Pop", "Rock", "Country", "EDM", "Jazz", "Blues", "Dance", "Acoustic", "Ballad"],
        datasets: [{
            data: [15, 10, 8, 12, 9, 5, 10, 7, 14], // Dữ liệu phần trăm hoặc số lượng cho từng thể loại nhạc
            backgroundColor: [
                '#4e73df', '#1cc88a', '#f6c23e', '#36b9cc', '#e74a3b',
                '#858796', '#f8f9fc', '#5a5c69', '#d1d3e2'
            ], // Màu sắc cho từng thể loại
            hoverBackgroundColor: [
                '#2e59d9', '#17a673', '#f4b619', '#2c9faf', '#e02d1b',
                '#6c757d', '#e0e0e0', '#343a40', '#c0c3ce'
            ],
            hoverBorderColor: "rgba(234, 236, 244, 1)",
        }],
    },
    options: {
        maintainAspectRatio: false,
        tooltips: {
            backgroundColor: "rgb(255,255,255)",
            bodyFontColor: "#858796",
            borderColor: '#dddfeb',
            borderWidth: 1,
            xPadding: 15,
            yPadding: 15,
            displayColors: false,
            caretPadding: 10,
        },
        legend: {
            display: false
        },
        cutoutPercentage: 60, // Cắt giữa biểu đồ để tạo hình doughnut
    },
});
