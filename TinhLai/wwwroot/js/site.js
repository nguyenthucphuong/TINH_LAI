// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    const inputFields = $('input[type="number"], input[type="text"]');
    inputFields.on('input', function () {
        let number = parseInt($(this).val().replace(/,/g, '').replace(/[^0-9]/g, ''));
        if (isNaN(number)) {
            number = 0;
        }
        $(this).val(number.toLocaleString('en-US'));
    });

    $('#ketqua').on('click', function () {
        $('form')[0].submit();
    });
});
