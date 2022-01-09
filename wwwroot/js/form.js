

$('select').prop("disabled", true);
$('#save').prop("disabled", true);
$('#cancel').prop("disabled", true);

document.getElementById("edit").onclick = function () { myFunction() };
function myFunction() {
    $('select').prop("disabled", false);
    $('#save').prop("disabled", false);
    $('#cancel').prop("disabled", false);
    $('#edit').prop("disabled", true);
}

