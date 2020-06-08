var chartData;
//google.load("visualization", "1", { packages: ["corechart"] });// cac loai chart con lai
//google.charts.setOnLoadCallback(drawChart);
//google.load("visualization", "1", { packages: ["gauge"] });// dung cho gaugeChart
//tongve();


$(document).ready(function () {

    google.charts.load('current', { 'packages': ['corechart'] });
    google.charts.setOnLoadCallback(drawChart);

    function drawChart() {
        var data = google.visualization.arrayToDataTable([
            ['Year', 'Sales', 'Expenses'],
            ['2004', 1000, 400],
            ['2005', 1170, 460],
            ['2006', 660, 1120],
            ['2007', 1030, 540]
        ]);

        var options = {
            title: '',
            curveType: 'function',
            vAxis: {
                title: 'Value',
                titleTextStyle: {
                    color: '#FF0000',
                    fontName: "Times New Roman",
                    fontSize: "20",
                    bold: true,
                    italic: false
                }
            },

            pointSize: 5,
            legend: { position: 'right' }
        };

        var chart = new google.visualization.LineChart(document.getElementById('chartLine'));

        chart.draw(data, options);
    }

    //setInterval(() => { tongve(); }, 1000)
});

//HamVe Line RealTime Chart
function ve_1(hamXuLy, vitri, kieu) {
    // Here We will fill chartData
    $.ajax({
        url: hamXuLy,
        data: "",
        dataType: "json",
        type: "POST",
        contentType: "application/json; chartset=utf-8",
        success: function (data) {
            chartData = data.d;
        },
        error: function () {
            alert("Error Loading Data! Please Try Again");
        }
    }).done(function () {
        // after complete loading data
        //google.setOnLoadCallback(drawChart2);
        drawChart2(vitri, kieu);

    });
}

//Options HamVe Line RealTime Chart
function drawChart2(vitri, kieu) {
    //var data = google.visualization.arrayToDataTable(chartData2);
    //alert(chartData2[1][0]);
    var data = google.visualization.arrayToDataTable(chartData);

    if (kieu == "ve_chart_1") {

        var options = {
            title: 'LINE REALTIME CHART ',
            curveType: 'function',
            vAxis: {
                title: 'Value',
                titleTextStyle: {
                    color: '#FF0000',
                    fontName: "Times New Roman",
                    fontSize: "20",
                    bold: true,
                    italic: false
                }
            },

            pointSize: 5,
            legend: { position: 'right' }
        };
    }
    var chart = new google.visualization.LineChart(document.getElementById(vitri));

    chart.draw(data, options);
}

function tongve() {
    ve_1("/Home/GetChartData","chartLine", "ve_chart_1");
}