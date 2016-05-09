$(document).ready(function() {
    $('#carBrand').on('change', function() {
        if ($(this).find(":selected").val() != "Выберите марку") {
            $('#carModel').prop('disabled', false);
        } else {
            $('#carModel').prop('disabled', true);
        }
    });

    $('#regConPass').on('keyup', function () {
        if ($(this).val() != $('#regPassword').val()) {
            $('#message').html('Пароли не совпадают').css('color', 'red'); 
        }
        else
        {
            $('#message').html('Пароли совпадают').css('color', 'green');
        }
        });

    $('#carTitle').on('input', (function() {
        var len = $(this).val().length;
        if (len > 100) {
            alert('Максимальное количество символов 100');
        }
    }));

    $('#relDate').on('input', function (e) {
        var year = $(this).val();
        if (isNaN(year)) {
            alert('Введёно не число!');
            $('#relDate').val('');
        }
    });

    $('#minRelDate').on('input', function (e) {
        var year_min = $(this).val();
        if (isNaN(year_min)) {
            alert('Введёно не число!');
            $('#minRelDate').val('');
        }
    });

    $('#maxRelDate').on('input', function (e) {
        var yea = $(this).val();
        if (isNaN(yea)) {
            alert('Введёно не число!');
            $('#maxRelDate').val('');
        }
    });

    $('#minPrice').on('input', function (e) {
        var pr_m = $(this).val();
        if (isNaN(pr_m)) {
            if (pr_m != '.') {
                alert('Введёно не число!');
                $('#maxPrice').val('');

            }
        }
    });

    $('#maxPrice').on('input', function (e) {
        var pr = $(this).val();
        if (isNaN(pr)) {
            if (pr != '.') {
                alert('Введёно не число!');
                $('#maxPrice').val('');

            }
        }
    });

    $('#price').on('input', function (e) {
        var price_car = $(this).val();
        if (isNaN(price_car)) {
            if ( price_car != '.') {
                alert('Введёно не число!');
                $('#price').val('');

            }
        }
    });
 
    $('#capacity').on('input', function (e) {
        var text = $(this).val();
        if (!/^[0-9,]+$/.test($('#capacity').val())) {
            text = text.substr(0, text.length - 1);
            $('#capacity').val(text);
        } else {
            if (!text.search(',')) {
                 text = text.substr(0, text.length - 1);
                $('#capacity').val(text);
            }
        }
    });

    $('#regForm').on('submit', function (e) {
        var hasError = '';
        $('#regForm input').map(function(id, index) {
            val = validate(index);
            hasError = 'sdj';
            if (!val) {
                e.preventDefault();
            }
        });
        if (hasError) {
            $('#messageFields').html('Заполните все поля!');
        }
    });

    function validate(fieldId) {
        var len = $(fieldId).val().length;
        if (len <= 2) {
            return false;
        } else {
            return true;
        }
    }

    $('#regName').on('keyup', function (e) {
        var text = $('#regName').val();
        if (/[-\s0-9`~!@#$%^&*()_=+\\|\[\]{};:'",.<>\/?]/.test($('#regName').val())) {
            text = text.substr(0, text.length - 1);
            $('#regName').val(text);
        } else {
            $('#regName').val(text);
        }

    });

    $('#regLName').on('keyup', function (e) {
        var text = $('#regLName').val();
        if (/[-\s0-9`~!@#$%^&*()_=+\\|\[\]{};:'",.<>\/?]/.test($('#regLName').val())) {
            text = text.substr(0, text.length - 1);
            $('#regLName').val(text);
        } else {
            $('#regLName').val(text);
        }

    });

    $('#regCity').on('keyup', function (e) {
        var text = $('#regCity').val();
        if (/[-\s0-9`~!@#$%^&*()_=+\\|\[\]{};:'",.<>\/?]/.test($('#regCity').val())) {
            text = text.substr(0, text.length - 1);
            $('#regCity').val(text);
        } else {
            $('#regCity').val(text);
        }

    });

    $('#regPhone').on('input', function (e) {
        var cap = $(this).val();
        if (isNaN(cap)) {
            if (cap != '.') {
                alert('Введёно не число!');
                $('#regPhone').val('');
            }
        }
    });

    $('#brand').on('keyup', function (e) {
        var text = $('#brand').val();
        if (/[-\s0-9`~!@#$%^&*()_=+\\|\[\]{};:'",.<>\/?]/.test($('#brand').val())) {
            text = text.substr(0, text.length - 1);
            $('#brand').val(text);
        } else {
            $('#brand').val(text);
        }

    });


    $('#color').on('keyup', function (e) {
        var text = $('#color').val();
        if (/[-\s0-9`~!@#$%^&*()_=+\\|\[\]{};:'",.<>\/?]/.test($('#color').val())) {
            text = text.substr(0, text.length - 1);
            $('#color').val(text);
        } else {
            $('#color').val(text);
        }

    });

    $('#addCar').on('submit', function (e) {
        var hasError = '';
        $('#addCar input').map(function (id, index) {
            val = validate(index);
            hasError = 'fejkl';
            if (!val) {
                e.preventDefault();
            }
        });
        if (hasError) {
            $('#mesFill').html('Заполните все поля!');
        }
    });

});
