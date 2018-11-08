
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
    var inputHidden = 'input#' + this.id;
    if ($(inputHidden).val() == 'True') {
        $(inputHidden).val('False');
    }
    else {
        $(inputHidden).val('True');
    }
});