

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
            $('#verticalModal').modal('show');
            console.log("hello");

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
        $('#verticalModal').modal('hide');
        console.log("hello");
    }
    else {
        ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
    }


}
$(document).ready(function () {
    $('#ThingIDoForm').submit(function (event) {
        event.preventDefault();
        var formData = $(this).serialize();

        $.ajax({
            url: '/Admin/ThingIDo/SubmitThingIDoFormModal',
            type: 'post',
            data: 'formData',
            beforeSend: function () {
                StartLoading();
            },
            success: function (res) {
                ThingIDoFormSubmited(res);
            },
            error: function () {
                CloseLoading();
                ShowMessage("عملیات با شکست مواجه شد", "پیغام خطا", "error")
            }
        });
    });
});

function DeleteThingIDo(id) {
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




