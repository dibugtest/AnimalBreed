$(document).ready(function () {
    $("#ddlAnimal").change(function () {
        var id = $(this).val();
        if (id != null) {

            ShowChart(id);
        }
   })
   
})
function ShowChart(id) {

    $.ajax({
        async: false,
        type: "POST",
        dataType: "json",
        data: JSON.stringify({ 'id': '" + projectId + "' }),
        contentType: "application/json; charset=utf-8",
        url: RootUrl + 'home/getMilkRecord?id='+id,
        success: function (chData) {
            if (chData.length == 0) {
                alert("No Project status Inserted.")
            }
            aData = chData;
            aLabels = aData.map(a => a.label);
            aDatasets1 = aData.map(a => a.value);
           
            var color = new Array();
            for (var i = 0; i < chData.length; i++) {
                if (i % 2 == 0) {
                    color.push("#4e73df");
                }
                else {
                    color.push("#1cc88a");
                }

            }
            var ctx = document.getElementById("myAreaChart");
            var myPieChart = new Chart(ctx, {
                type: 'line',
                data: {
                    labels: aLabels,// ["Direct", "Referral", "Social"],
                    datasets: [{
                        data: aDatasets1,// [55, 30, 15],
                        //backgroundColor: color,//['#4e73df', '#1cc88a', '#36b9cc'],
                        //hoverBackgroundColor: color,// ['#2e59d9', '#17a673', '#2c9faf'],
                        hoverBorderColor: "rgba(234, 236, 244, 1)",
                    }],
                },
                options: {
                    scales: {
                        xAxes: [{
                            scaleLabel: {
                                display: true,
                                labelString: 'Date'
                            }
                        }],
                        yAxes: [{
                            scaleLabel: {
                                display: true,
                                labelString: 'Milk Volume (Litres)'
                            }
                        }]
                    },     
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
                    cutoutPercentage: 80,
                },
            });
        }
    })

}