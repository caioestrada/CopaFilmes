
var $checkboxes = $('input[type="checkbox"]');
$checkboxes.change(function () {
    var countChecados = $checkboxes.filter(':checked').length;
    if (countChecados != 8)
        $('#btnGerarCampeonato').prop('disabled', true);
    else
        $('#btnGerarCampeonato').prop('disabled', false);

    $('#totalChecados').text(countChecados);
});

$('input').click(function () {
    $('input#' + this.id).val('True');
});