$('#btnPersonal').click(function () {

    validatePersonalInformation();
});

$('#btnEducational').click(function () {
    validateEducationInformation();
});

$('#btnFamily').click(function () {
    saveFamilyInformation();
});

$('#btnPI').click(function () {
    validatePIInformation();
});

function validatePersonalInformation() {
    $('#btnPersonal').prop('disabled', true);
    $('#btnPersonal').text("Please wait...");

    let formErrors = [];
    if (!$('#firstname').val()) { formErrors.push('First Name is required'); }
    if (!$('#phone').val()) { formErrors.push('Phone Number is required'); }
    if (!$('#email').val()) { formErrors.push('Email is required'); }
    if (!isValidEmailAddress($('#email').val())) { formErrors.push('Invalid email address'); }
    if (!$('#dob').val()) { formErrors.push('Date of Birth is required'); }
    if (!$('#gender').val()) { formErrors.push('Gender is required'); }
    if (!$('#address').val()) { formErrors.push('Address is required'); }
    if (formErrors.length > 0) {
        formErrors.forEach(function (item, index) {
            notifyError(item);
        });
        $('#btnPersonal').prop('disabled', false);
        $('#btnPersonal').text("Save Changes");
        return;
    }
    let StudentPersonalInfoVM = {
        userId: $('#LoggedInUser_Id').val(),
        firstName: $('#firstname').val(),
        lastName: $('#lastname').val(),
        phoneNumber: $('#phone').val(),
        email: $('#email').val(),
        dateOfBirth: $('#dob').val(),
        gender: $('#gender').val(),
        address: $('#address').val()
    };
    $.ajax({
        type: "POST",
        url: "/api/Student/updateStudentPersonalInfo",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(StudentPersonalInfoVM),
        success: function (response) {
            notifySucess("Saved Successfully!")
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

function validateEducationInformation() {
    $('#btnEducational').prop('disabled', true);
    $('#btnEducational').text("Please wait...");

    let formErrors = [];
    if (!$('#className').val()) { formErrors.push('Class is required'); }
    if (!$('#schoolname').val()) { formErrors.push('School Name is required'); }
    if ($('#className').val() == "11th" || $('#className').val() == "12th" || $('#className').val() == "Undergraduate") {
        if (!$('#subject1').val()) { formErrors.push('Subject 1 is required'); }
        if (!$('#subject2').val()) { formErrors.push('Subject 2 is required'); }
        if (!$('#subject3').val()) { formErrors.push('Subject 3 is required'); }
        if (!$('#subject4').val()) { formErrors.push('Subject 4 is required'); }
        if (!$('#subject5').val()) { formErrors.push('Subject 5 is required'); }
    }

    if (formErrors.length > 0) {
        formErrors.forEach(function (item, index) {
            notifyError(item);
        });
        $('#btnEducational').prop('disabled', false);
        $('#btnEducational').text("Save Changes");
        return;
    }
    let StudentEducationInfoVM = {
        userId: $('#LoggedInUser_Id').val(),
        studentClass: $('#className').val(),
        subject1: $('#subject1').val(),
        subject2: $('#subject2').val(),
        subject3: $('#subject3').val(),
        subject4: $('#subject4').val(),
        subject5: $('#subject5').val(),
        schoolName: $('#schoolname').val()
    };
    $.ajax({
        type: "POST",
        url: "/api/Student/updateStudentEducationInfo",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(StudentEducationInfoVM),
        success: function (response) {
            notifySucess("Saved Successfully!")
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
    $('#btnEducational').prop('disabled', false);
    $('#btnEducational').text("Save Changes");
}

function saveFamilyInformation() {
    $('#btnFamily').prop('disabled', true);
    $('#btnFamily').text("Please wait...");

    let StudentFamilyInfoVM = {
        userId: $('#LoggedInUser_Id').val(),
        fatherName: $('#Profile_FatherName').val(),
        motherName: $('#Profile_MotherName').val(),
        fatherQualification: $('#Profile_FatherQualification').val(),
        motherQualification: $('#Profile_MotherQualification').val(),
        fatherProfession: $('#Profile_FatherProfession').val(),
        motherProfession: $('#Profile_MotherProfession').val()
    };
    $.ajax({
        type: "POST",
        url: "/api/Student/updateStudentFamilyInfo",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(StudentFamilyInfoVM),
        success: function (response) {            
            //update these fields under PI tab also
            $('#profileFatherName').val($('#Profile_FatherName').val());
            $('#profileMotherName').val($('#Profile_MotherName').val());
            $('#profileFatherProfession').val($('#Profile_FatherProfession').val());
            $('#profileMotherProfession').val($('#Profile_MotherProfession').val());
            $('#profileFatherQualification').val($('#Profile_FatherQualification').val());
            $('#profileMotherQualification').val($('#Profile_MotherQualification').val());

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
    $('#btnFamily').prop('disabled', false);
    $('#btnFamily').text("Save Changes");
}

function validatePIInformation() {
    $('#btnPI').prop('disabled', true);
    $('#btnPI').text("Please wait...");

    let formErrors = [];
    if (!$('#profileFatherName').val()) { formErrors.push('Father name is required'); }
    if (!$('#profileMotherName').val()) { formErrors.push('Mother name is required'); }
    if (!$('#profileFatherProfession').val()) { formErrors.push('Father profession is required'); }
    if (!$('#profileMotherProfession').val()) { formErrors.push('Mother profession is required'); }
    if (!$('#profileFatherQualification').val()) { formErrors.push('Father qualification is required'); }
    if (!$('#profileMotherQualification').val()) { formErrors.push('Mother qualification is required'); }
    if (!$('#Siblings').val()) { formErrors.push('Sibling value is required'); }
    if (!$('#FamilyType').val()) { formErrors.push('Family Type value is required'); }
    if (!$('#Profile_Grades').val()) { formErrors.push('Grade value is required'); }
    if (!$('#Profile_FavoriteSubject').val()) { formErrors.push('Favorite Subject value is required'); }
    if (!$('#Profile_Achievements').val()) { formErrors.push('Achievements value is required'); }
    if (!$('#Profile_PositionOfResponsibility').val()) { formErrors.push('Position of responsibility value is required'); }
    if (!$('#Profile_BestVacation').val()) { formErrors.push('Best vacation value is required'); }
    if (!$('#Profile_HowManyFriends').val()) { formErrors.push('"How many friends?" value is required'); }
    if (!$('#exampleFormdreamcareer1').val()) { formErrors.push('Dream Career 1 value is required'); }
    if (!$('#exampleFormdreamcareer2').val()) { formErrors.push('Dream Career 2 value is required'); }
    if (!$('#exampleFormWhatMotivatesYou').val()) { formErrors.push('"What motivates you" value is required'); }
    if (!$('#Profile_WhyThisCareer').val()) { formErrors.push('"Why do you like this career" value is required'); }    
    if (!$('#DifferentlyAbled').val()) { formErrors.push('"Differently abled" value is required'); }    
    if (!$('#Profile_ExpectationsFromUpclass').val()) { formErrors.push('"What are your expectation from UpClass?" value is required'); }    
    if (!$('#Profile_HowYourFriendsDescribeYou').val()) { formErrors.push('"How your friends describe you?" value is required'); }    
    if (!$('#Profile_HowYourParentsDecribeYou').val()) { formErrors.push('"How your family describe you?" value is required'); }    

    if (formErrors.length > 0) {
        formErrors.forEach(function (item, index) {
            notifyError(item);
        });
        $('#btnPI').prop('disabled', false);
        $('#btnPI').text("Save Changes");
        return;
    }
    let StudentPIVM = {
        userId: $('#LoggedInUser_Id').val(),
        fatherName: $('#profileFatherName').val(),
        motherName: $('#profileMotherName').val(),
        fatherQualification: $('#profileFatherQualification').val(),
        motherQualification: $('#profileMotherQualification').val(),
        fatherProfession: $('#profileFatherProfession').val(),
        motherProfession: $('#profileMotherProfession').val(),
        siblings: $('#Siblings').val(),
        elderYounger: $('#Profile_ElderorYounger').val(),
        familyIncome: $('#Profile_FamilyIncome').val(),
        familyType: $('#FamilyType').val(),
        grades: $('#Profile_Grades').val(),
        favouriteSubject: $('#Profile_FavoriteSubject').val(),
        achievements: $('#Profile_Achievements').val(),
        positionOfResponsibility: $('#Profile_PositionOfResponsibility').val(),
        facebook: $('#Profile_Facebook').val(),
        instagram: $('#Profile_Instagram').val(),
        linkedIn: $('#Profile_Linkedin').val(),
        twitter: $('#Profile_Twitter').val(),
        numberofFriends: $('#Profile_HowManyFriends').val(),
        bestVacation: $('#Profile_BestVacation').val(),
        dreamCareer1: $('#exampleFormdreamcareer1').val(),
        dreamCareer2: $('#exampleFormdreamcareer2').val(),
        motivation: $('#exampleFormWhatMotivatesYou').val(),
        whyThisCareer: $('#Profile_WhyThisCareer').val(),
        differentlyAbled: $('#DifferentlyAbled').val(),
        expectationFromUpclass: $('#Profile_ExpectationsFromUpclass').val(),
        howYourFriendsDescribeYou: $('#Profile_HowYourFriendsDescribeYou').val(),
        howYourParentsDescribeYou: $('#Profile_HowYourParentsDecribeYou').val()
    };
    $.ajax({
        type: "POST",
        url: "/api/Student/updateStudentPI",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(StudentPIVM),
        success: function (response) {
            notifySucess("Saved Successfully!")
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
    $('#btnPI').prop('disabled', false);
    $('#btnPI').text("Save Changes");
}

function removeProfileImage() {
    Swal.fire({
        title: 'Are you sure?',
        text: "This would remove your profile picture.",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, remove!'
    }).then((result) => {
        if (result.value) {
            $.ajax({
                url: "/api/Student/removeProfilePicture",
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    if (response == true) {
                        $("#formProfilePicture").submit();
                    } else {
                        notifyError("Unexpected error!");
                    }
                }
            });
        }
    });
}