$('#btnUpdate').click(function () {
    saveRoadmap();
});

function saveRoadmap() {
    $('#btnPersonal').prop('disabled', true);
    $('#btnPersonal').text("Please wait...");

    let RoadmapViewModel = {
        UserId: $('#userId').val(),
        CareerPathOne1: $('#UserInformation_CareerPathOne1').val(),
        CareerPathOne2: $('#UserInformation_CareerPathOne2').val(),
        CareerPathOne3: $('#UserInformation_CareerPathOne3').val(),
        CareerPathOne4: $('#UserInformation_CareerPathOne4').val(),
        CareerPathOne5: $('#UserInformation_CareerPathOne5').val(),
        CareerPathTwo1: $('#UserInformation_CareerPathTwo1').val(),
        CareerPathTwo2: $('#UserInformation_CareerPathTwo2').val(),
        CareerPathTwo3: $('#UserInformation_CareerPathTwo3').val(),
        CareerPathTwo4: $('#UserInformation_CareerPathTwo4').val(),
        CareerPathTwo5: $('#UserInformation_CareerPathTwo5').val(),
        CareerPathThree1: $('#UserInformation_CareerPathThree1').val(),
        CareerPathThree2: $('#UserInformation_CareerPathThree2').val(),
        CareerPathThree3: $('#UserInformation_CareerPathThree3').val(),
        CareerPathThree4: $('#UserInformation_CareerPathThree4').val(),
        CareerPathThree5: $('#UserInformation_CareerPathThree5').val() 
    };
    $.ajax({
        type: "POST",
        url: "/api/Roadmap/updateRoadmap",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(RoadmapViewModel),
        success: function (response) {
            notifySucess("Saved Successfully!");
        },
        failure: function (response) {
            Swal.fire({
                icon: 'warning',
                title: 'An error occured',
                text: response.responseText,
                allowOutsideClick: false,
                confirmButtonText: 'Try Again'
            });
        },
        error: function (response) {
            Swal.fire({
                icon: 'warning',
                title: 'An error occured',
                text: response.responseText,
                allowOutsideClick: false,
                confirmButtonText: 'Try Again'
            });
        }
    });

    $('#btnPersonal').prop('disabled', false);
    $('#btnPersonal').text("Save Changes");
}