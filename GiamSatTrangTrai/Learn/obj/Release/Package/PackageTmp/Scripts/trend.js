$(document).ready(function () {
    //var ctx = document.getElementById('myChart').getContext('2d');
    //var myChart = new Chart(ctx, {
    //    type: 'bar',
    //    data: {
    //        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
    //        datasets: [{
    //            label: '# of Votes',
    //            data: [12, 19, 3, 5, 2, 3],
    //            backgroundColor: [
    //                'rgba(255, 99, 132, 0.2)',
    //                'rgba(54, 162, 235, 0.2)',
    //                'rgba(255, 206, 86, 0.2)',
    //                'rgba(75, 192, 192, 0.2)',
    //                'rgba(153, 102, 255, 0.2)',
    //                'rgba(255, 159, 64, 0.2)'
    //            ],
    //            borderColor: [
    //                'rgba(255, 99, 132, 1)',
    //                'rgba(54, 162, 235, 1)',
    //                'rgba(255, 206, 86, 1)',
    //                'rgba(75, 192, 192, 1)',
    //                'rgba(153, 102, 255, 1)',
    //                'rgba(255, 159, 64, 1)'
    //            ],
    //            borderWidth: 1
    //        }]
    //    },
    //    options: {
    //        scales: {
    //            yAxes: [{
    //                ticks: {
    //                    beginAtZero: true
    //                }
    //            }]
    //        }
    //    }
    //});

    var ctx = document.getElementById('chartLine').getContext('2d');
    var myChart = new Chart(ctx, {
        type: 'line',
        data: {
            //labels: ["21:01:00", "21:02:00", "21:03:00", "21:04:00", "21:05:00", "21:06:00", "21:07:00", "21:08:00", "21:09:00", "21:10:00"],
            labels: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
            datasets: [{
                data: [30, 31.5, 29.9, 28, 28.5, 29.6, 30.1, 27.6, 28, 30.9],
                label: "Nhiệt độ",
                borderColor: "#3e95cd",
                fill: false
            },
            {
                data: [40.1, 40.6, 45.9, 41, 35.5, 41, 35.2, 40, 39.9, 44],
                label: "Độ ẩm",
                borderColor: "#8e5ea2",
                fill: false
            }
            //{
            //    data: [30, 30, 30, 30, 25, 45, 45, 40, 38, 30],
            //    label: "Tần số",
            //    borderColor: "#3cba9f",
            //    fill: false
            //},
            //{
            //    data: [90, 91, 92, 90.1, 89.9, 91.5, 92, 91.5, 90.9, 90.5],
            //    label: "O2",
            //    borderColor: "#e8c3b9",
            //    fill: false
            //},
            //{
            //    data: [6, 3, 2, 2, 7, 8.9, 9.5, 8.8, 8.9, 9],
            //    label: "CO2",
            //    borderColor: "#c45850",
            //    fill: false
            //}, {
            //    data: [6, 3, 2, 2, 7, 10, 15.5, 12, 10.9, 9],
            //    label: "NH3",
            //    borderColor: "#ff0000",
            //    fill: false
            //}
            ]
        },
        options: {
            title: {
                display: true,
                text: 'Biểu đồ thời gian thực các thông số'
            },
            //scales: {
            //    xAxes: [{
            //        type: 'time',
            //        time: {
            //            displayFormats: {
            //                second : 'HH:mm:ss'
            //            }
            //        }
            //    }]
            //}
        }
    });
});
