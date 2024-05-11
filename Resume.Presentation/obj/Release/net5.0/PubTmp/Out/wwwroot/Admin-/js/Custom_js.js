
function StartLoading(element = 'body') {
    $(element).waitMe({
        effect: 'bounce',
        text: 'لطفا صبر کنید ...',
        bg: 'rgba(255, 255, 255, 0.7)',
        color: '#000'
    });
}

function CloseLoading(element = 'body') {
    $(element).waitMe('hide');
}

// start thing i do ajax
function LoadThingIDoFormModal(id) {
    $.ajax({
        url: "/Admin/ThingIDo/LoadThingIDoFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-fade-content").html(res);

            $('#ThingIDoForm').data('validator', null);
            $.validator.unobtrusive.parse("#ThingIDoForm");

            $('#exampleModalCenter').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}

function ThingIDoFormSubmited(res) {
    CloseLoading();

    if (res.status === "Success") {
        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
        $('#exampleModalCenter').modal('hide');
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }
    

}

function DeleteThingIDo(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText:'لغو کردن'

    }).then((willDelete) => {

  
        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/ThingIDo/DeleteThingIDo",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                        $('#exampleModalCenter').modal('hide');
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };

        
    })
}

// end thing i do ajax

// start education ajax


function LoadEducationFormModal(id) {
    $.ajax({
        url: "/Admin/Education/LoadEducationFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-fade-content").html(res);

            $('#EducationForm').data('validator', null);
            $.validator.unobtrusive.parse("#EducationForm");

            $('#exampleModalCenter').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}

function EducationFormSubmited(res) {
    CloseLoading();

    if (res.status === "Success") {
        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
        $('#exampleModalCenter').modal('hide');
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }


}

function DeleteEducation(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText: 'لغو کردن'

    }).then((willDelete) => {


        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/Education/DeleteEducation",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                        $('#exampleModalCenter').modal('hide');
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };


    })
}

// end education ajax
// start experience ajax
function LoadExperienceFormModal(id) {
    $.ajax({
        url: "/Admin/Experience/LoadExperienceFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-fade-content").html(res);

            $('#ExperienceForm').data('validator', null);
            $.validator.unobtrusive.parse("#ExperienceForm");

            $('#exampleModalCenter').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}

function ExperienceFormSubmited(res) {
    CloseLoading();

    if (res.status === "Success") {
        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
        $('#exampleModalCenter').modal('hide');
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }


}

function DeleteExperience(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText: 'لغو کردن'

    }).then((willDelete) => {


        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/Experience/DeleteExperience",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                        $('#exampleModalCenter').modal('hide');
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };


    })
}
// end experience ajax
// start skill ajax
function LoadSkillFormModal(id) {
    $.ajax({
        url: "/Admin/Skill/LoadSkillFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-fade-content").html(res);

            $('#SkillForm').data('validator', null);
            $.validator.unobtrusive.parse("#SkillForm");

            $('#exampleModalCenter').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}

function SkillFormSubmited(res) {
    CloseLoading();

    if (res.status === "Success") {
        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
        $('#exampleModalCenter').modal('hide');
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }


}

function DeleteSkill(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText: 'لغو کردن'

    }).then((willDelete) => {


        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/Skill/DeleteSkill",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                        $('#exampleModalCenter').modal('hide');
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };


    })
}
// end skill ajax

// start customer feedback ajax
function LoadCustomerFeedbackFormModal(id) {
    $.ajax({
        url: "/Admin/CustomerFeedback/LoadCustomerFeedbackFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-fade-content").html(res);

            $('#CustomerFeedbackForm').data('validator', null);
            $.validator.unobtrusive.parse("#CustomerFeedbackForm");

            $('#exampleModalCenter').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}

function CustomerFeedbackFormSubmited(res) {
    CloseLoading();

    if (res.status === "Success") {
        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
        $('#exampleModalCenter').modal('hide');
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }


}

function DeleteCustomerFeedback(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText: 'لغو کردن'

    }).then((willDelete) => {


        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/CustomerFeedback/DeleteCustomerFeedback",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                        $('#exampleModalCenter').modal('hide');
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };


    })
}
// end customer feedback ajax

// start About Me ajax
function LoadAboutMeFormModal(id) {
    $.ajax({
        url: "/Admin/AboutMe/LoadAboutMeFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-fade-content").html(res);

            $('#AboutMeForm').data('validator', null);
            $.validator.unobtrusive.parse("#AboutMeForm");

            $('#exampleModalCenter').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}

function AboutMeFormSubmited(res) {
    CloseLoading();

    if (res.status === "Success") {
        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
        $('#exampleModalCenter').modal('hide');
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }


}

function DeleteAboutMe(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText: 'لغو کردن'

    }).then((willDelete) => {


        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/AboutMe/DeleteAboutMe",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                        $('#exampleModalCenter').modal('hide');
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };


    })
}
// end About Me ajax

// start ItemIDo ajax
function LoadItemIDoFormModal(id) {
    $.ajax({
        url: "/Admin/ItemIDo/LoadItemIDoFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-fade-content").html(res);

            $('#ItemIDoForm').data('validator', null);
            $.validator.unobtrusive.parse("#ItemIDoForm");

            $('#exampleModalCenter').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}
function ItemIDoFormSubmited(res) {
    CloseLoading();

    if (res.status === "Success") {
        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
        $('#exampleModalCenter').modal('hide');
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }


}
function DeleteItemIDo(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText: 'لغو کردن'

    }).then((willDelete) => {


        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/ItemIDo/DeleteItemIDo",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                        $('#exampleModalCenter').modal('hide');
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };


    })
}
// end ItemIDo ajax


// start ItemIDo ajax
function LoadInformationFormModal(id) {
    $.ajax({
        url: "/Admin/Information/LoadInformationFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-fade-content").html(res);

            $('#InformationForm').data('validator', null);
            $.validator.unobtrusive.parse("#InformationForm");

            $('#exampleModalCenter').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}
function InformationFormSubmited(res) {
    CloseLoading();

    if (res.status === "Success") {
        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
        $('#exampleModalCenter').modal('hide');
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }


}
function DeleteInformation(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText: 'لغو کردن'

    }).then((willDelete) => {


        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/Information/DeleteInformation",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                        $('#exampleModalCenter').modal('hide');
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };


    })
}
// end Information ajax

// start PortfolioCategory ajax
function LoadPortfolioCategoryFormModal(id) {
    $.ajax({
        url: "/Admin/PortfolioCategory/LoadPortfolioCategoryFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-fade-content").html(res);

            $('#PortfolioCategoryForm').data('validator', null);
            $.validator.unobtrusive.parse("#PortfolioCategoryForm");

            $('#exampleModalCenter').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}
function PortfolioCategoryFormSubmited(res) {
    CloseLoading();

    if (res.status === "Success") {
        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
        $('#exampleModalCenter').modal('hide');
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }


}
function DeletePortfolioCategory(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText: 'لغو کردن'

    }).then((willDelete) => {


        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/PortfolioCategory/DeletePortfolioCategory",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                        $('#exampleModalCenter').modal('hide');
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };


    })
}
// end PortfolioCategory ajax

// start Portfolio ajax
function LoadPortfolioFormModal(id) {
    $.ajax({
        url: "/Admin/Portfolio/LoadPortfolioFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-fade-content").html(res);

            $('#PortfolioForm').data('validator', null);
            $.validator.unobtrusive.parse("#PortfolioForm");

            $('#exampleModalCenter').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}
function PortfolioFormSubmited(res) {
    CloseLoading();

    if (res.status === "Success") {
        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
        $('#exampleModalCenter').modal('hide');
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }


}
function DeletePortfolio(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText: 'لغو کردن'

    }).then((willDelete) => {


        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/Portfolio/DeletePortfolio",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                        $('#exampleModalCenter').modal('hide');
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };


    })
}
// end Portfolio ajax
// start Message ajax
function DeleteMessage(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText: 'لغو کردن'

    }).then((willDelete) => {


        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/Home/DeleteMessage",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };


    })
}
// end Message ajax

// start Portfolio ajax
function LoadUserAdminFormModal(id) {
    $.ajax({
        url: "/Admin/Account/LoadUserAdminFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-fade-content").html(res);

            $('#UserAdminForm').data('validator', null);
            $.validator.unobtrusive.parse("#UserAdminForm");

            $('#exampleModalCenter').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}
function UserAdminFormSubmited(res) {
    CloseLoading();

    if (res.status === "Success") {
        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
        $('#exampleModalCenter').modal('hide');
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }


}
function DeleteUserAdmin(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText: 'لغو کردن'

    }).then((willDelete) => {


        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/Account/DeleteUserAdmin",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                        $('#exampleModalCenter').modal('hide');
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };


    })
}
// end Portfolio ajax

// start Customer Logo ajax
function LoadCustomerLogoFormModal(id) {
    $.ajax({
        url: "/Admin/CustomerLogo/LoadCustomerLogoFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-fade-content").html(res);

            $('#CustomerLogoForm').data('validator', null);
            $.validator.unobtrusive.parse("#CustomerLogoForm");

            $('#exampleModalCenter').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}
function CustomerLogoFormSubmited(res) {
    CloseLoading();

    if (res.status === "Success") {
        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
        $('#exampleModalCenter').modal('hide');
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }


}
function DeleteCustomerLogo(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText: 'لغو کردن'

    }).then((willDelete) => {


        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/CustomerLogo/DeleteCustomerLogo",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                        $('#exampleModalCenter').modal('hide');
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };


    })
}
// end Customer Logo ajax

// start SocialMedia ajax
function LoadSocialMediaFormModal(id) {
    $.ajax({
        url: "/Admin/SocialMedia/LoadSocialMediaFormModal",
        type: "get",
        data: {
            id: id
        },
        beforSend: function () {
            StartLoading();
        },
        success: function (res) {
            CloseLoading();

            $("#modal-fade-content").html(res);

            $('#SocialMediaForm').data('validator', null);
            $.validator.unobtrusive.parse("#SocialMediaForm");

            $('#exampleModalCenter').modal('show');

        },
        error: function () {
            CloseLoading();
        }
    });
}
function SocialMediaFormSubmited(res) {
    CloseLoading();

    if (res.status === "Success") {
        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
        $('#exampleModalCenter').modal('hide');
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }


}
function DeleteSocialMedia(id) {
    Swal.fire({
        title: "اخطار",
        text: "آیا از حذف این آیکون اطمینان دارید؟",
        icon: "warning",
        dangerMode: true,
        showDenyButton: true,
        confirmButtonText: 'حذف',
        denyButtonText: 'لغو کردن'

    }).then((willDelete) => {


        if (willDelete.isConfirmed) {
            $.ajax({
                url: "/Admin/SocialMedia/DeleteSocialMedia",
                type: "get",
                data: {
                    id: id
                },
                beforSend: function () {
                    StartLoading();
                },
                success: function (res) {
                    CloseLoading();
                    if (res.status === "Success") {
                        ShowMessage("عملیات با موفقیت انجام شد", "پیغام موفقیت", "success")
                        $(`#list-thing-${id}`).remove();
                        $('#exampleModalCenter').modal('hide');
                    }
                    else {
                        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
                    }
                },
                error: function () {
                    CloseLoading();
                }
            });
        };


    })
}
// end SocialMedia ajax