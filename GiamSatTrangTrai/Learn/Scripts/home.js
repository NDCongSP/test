$(document).ready(function () {
    //tao time de quét data liên tục
    setInterval(() => {
        loadData();
    }, 1000)

    //dng ky su kien cho nut nhan
    $('#aChange').click(() => {
        $('#myModal').modal('show');
        //$('#btnUpdate').show();
    });

    $('#btnUpdate').click(() => {
        var obj = {
            Id: 1,
            luckyNum: $('#luckyNum').val(),//là thẻ input
        };

        $.ajax({
            url: "/Home/Update",
            data: JSON.stringify(obj),
            type: "POST",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {
                if (result.Status == 'Ok') {
                    alert('Cap nhat thanh cong');
                    $('#myModal').modal('hide');
                }
                else
                    alert('Cap nhat that bai');
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    });

    $('#btnUpdateAccount').click(() => {
        var obj = {
            password: $('#oldPass').val(),
            newPassword: $('#newPass').val(),//là thẻ input
            reNewPass: $('#reNewPass').val(),
        };

        $.ajax({
            url: "/Home/UpdatePass",
            data: JSON.stringify(obj),
            type: "POST",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {
                if (result.Status == 'Ok') {
                    alert('Cap nhat thanh cong');
                    window.location = "/WebSite/Login/Index";
                }
                else
                    alert('Cap nhat that bai');
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    });
});

//Load Data function  
function loadData() {
    $.ajax({
        url: "/Home/GetRealTimeValues/",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            //trả về thẻ html
            $('#labNhietDo').html(result.nhietDo + "<small> oC</small>");
            $('#labDoAm').html(result.doAm + "<small> %</small>");
            $('#labTanSo').html(result.tanSo + "<small> Hz</small>");
            $('#labO2').html(result.o2);
            $('#labCO2').html(result.co2);
            $('#labNH3').html(result.nh3);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}  
