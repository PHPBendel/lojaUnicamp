/** FUN��ES USADAS NA P�GINA **/

var SPMaskBehavior = function (val) {
    return val.replace(/\D/g, '').length === 11 ? '(00) 00000-0000' : '(00) 0000-00009';
},
    spOptions = {
        onKeyPress: function (val, e, field, options) {
            field.mask(SPMaskBehavior.apply({}, arguments), options);
        }
    };


function validarCpf(cpf) {
    var Soma;
    var Resto;
    Soma = 0;



    if ((cpf == "00000000000") || (cpf.length != 11)) return false;

    for (i = 1; i <= 9; i++) Soma = Soma + parseInt(cpf.substring(i - 1, i)) * (11 - i);
    Resto = (Soma * 10) % 11;

    if ((Resto == 10) || (Resto == 11)) Resto = 0;
    if (Resto != parseInt(cpf.substring(9, 10))) return false;

    Soma = 0;
    for (i = 1; i <= 10; i++) Soma = Soma + parseInt(cpf.substring(i - 1, i)) * (12 - i);
    Resto = (Soma * 10) % 11;

    if ((Resto == 10) || (Resto == 11)) Resto = 0;
    if (Resto != parseInt(cpf.substring(10, 11))) return false;
    return true;


}

function isEmail(email) {
    var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(email);
}

function validaTelefone(value) {

    value = value.replace("(", "");
    value = value.replace(")", "");
    value = value.replace("-", "");
    value = value.replace(" ", "").trim();
    if (value == '0000000000') {
        return false;
    } else if (value == '00000000000') {
        return false;
    }
    if (["00", "01", "02", "03", , "04", , "05", , "06", , "07", , "08", "09", "10"].indexOf(value.substring(0, 2)) != -1) {
        return false;
    }
    if (value.length < 10 || value.length > 11) {
        return false;
    }

    return true;
}

/** INIC�O PROGRAMA��O DA P�GINA  **/

$(document).ready(function () {


    var $campoCpf = $("#ContentPlaceHolder1_cpf_usu");
    $campoCpf.mask('000.000.000-00', { reverse: true });

    $campoCpf.blur(function () {

        var $valorCpf = $campoCpf.val();

        $valorCpf = $valorCpf.replace('.', '');
        $valorCpf = $valorCpf.replace('.', '');
        $valorCpf = $valorCpf.replace('-', '');

        if (!validarCpf($valorCpf) && $valorCpf != "") {
            $('#ContentPlaceHolder1_erroCadastro').fadeIn();
            $('#ContentPlaceHolder1_erroCadastro').children().text("CPF Inv�lido");
        }
        else
            $('#ContentPlaceHolder1_erroCadastro').hide();

    });


    var $campoNome = $('#ContentPlaceHolder1_nome_usu');

    $campoNome.blur(function () {

        var $nome = $campoNome.val();

        $nome = $nome.split(" ");

        if ($nome.length < 2 && $nome != "") {
            $('#ContentPlaceHolder1_erroCadastro').fadeIn();
            $('#ContentPlaceHolder1_erroCadastro').children().text("Digite o nome completo");
        }
        else
            $('#ContentPlaceHolder1_erroCadastro').hide();
    });

    var $campoEmail = $('#ContentPlaceHolder1_email_usu');

    $campoEmail.blur(function () {

        var $email = $campoEmail.val();

        if (!isEmail($email) && $email != "") {
            $('#ContentPlaceHolder1_erroCadastro').fadeIn();
            $('#ContentPlaceHolder1_erroCadastro').children().text("Digite um e-mail v�lido");
        }
        else
            $('#ContentPlaceHolder1_erroCadastro').hide();
    });

    var $campoTel = $("#ContentPlaceHolder1_tel_usu");
    $campoTel.mask(SPMaskBehavior, spOptions);

    $campoTel.blur(function () {
        var $telefone = $campoTel.val();

        if (!validaTelefone($telefone) && $telefone != "") {
            $('#ContentPlaceHolder1_erroCadastro').fadeIn();
            $('#ContentPlaceHolder1_erroCadastro').children().text("Digite um telefone v�lido");
        }
        else
            $('#ContentPlaceHolder1_erroCadastro').hide();
    });

    var $campoCel = $("#ContentPlaceHolder1_cel_usu");
    $campoCel.mask(SPMaskBehavior, spOptions);
    $campoCel.blur(function () {
        var $telefone = $campoCel.val();

        if (!validaTelefone($telefone) && $telefone != "") {
            $('#ContentPlaceHolder1_erroCadastro').fadeIn();
            $('#ContentPlaceHolder1_erroCadastro').children().text("Digite um telefone v�lido");
        }
        else
            $('#ContentPlaceHolder1_erroCadastro').hide();
    });

    $("#ContentPlaceHolder1_cep_usu").mask("00000-000");
    $("#ContentPlaceHolder1_cep_usu").blur(function () {

        //Nova vari�vel "cep" somente com d�gitos.
        var cep = $(this).val().replace(/\D/g, '');
        var validacep = /^[0-9]{8}$/;

        if (!validacep.test(cep) && cep != "") {
            $('#ContentPlaceHolder1_erroCadastro').fadeIn();
            $('#ContentPlaceHolder1_erroCadastro').children().text("Digite um CEP v�lido");
        }
        else
            $('#ContentPlaceHolder1_erroCadastro').hide();

        //Verifica se campo cep possui valor informado.
        if (cep != "") {

            //Express�o regular para validar o CEP.


            //Valida o formato do CEP.
            if (validacep.test(cep)) {

                //Preenche os campos com "..." enquanto consulta webservice.
                $("#ContentPlaceHolder1_log_usu").val("...");
                $("#ContentPlaceHolder1_bairro_usu").val("...");
                $("#ContentPlaceHolder1_cidade_usu").val("...");
                $("#ContentPlaceHolder1_estado_usu").val("...");

                //Consulta o webservice viacep.com.br/
                $.getJSON("//viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {

                    if (!("erro" in dados)) {
                        //Atualiza os campos com os valores da consulta.
                        $("#ContentPlaceHolder1_log_usu").val(dados.logradouro);
                        $("#ContentPlaceHolder1_bairro_usu").val(dados.bairro);
                        $("#ContentPlaceHolder1_cidade_usu").val(dados.localidade);
                        $("#ContentPlaceHolder1_estado_usu").val(dados.uf);

                    } //end if.
                    else {
                        //CEP pesquisado n�o foi encontrado.
                        limpa_formul�rio_cep();
                        alert("CEP n�o encontrado.");
                    }
                });
            } //end if.
            else {
                //cep � inv�lido.
                limpa_formul�rio_cep();
                alert("Formato de CEP inv�lido.");
            }
        } //end if.
        else {
            //cep sem valor, limpa formul�rio.
            limpa_formul�rio_cep();
        }
    });

    var validaSenha = /^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d!$%@#��*?&]{7,}$/;

    var $campoSenha = $('#ContentPlaceHolder1_senha');

    $campoSenha.blur(function () {
        var $senha = $campoSenha.val();

    if (!validaSenha.test($senha) && $senha != "") {
        $('#ContentPlaceHolder1_erroCadastro').fadeIn();
        $('#ContentPlaceHolder1_erroCadastro').children().text("Digite uma senha forte (7 caracteres, com n�meros e letras)");
    }
    else
        $('#ContentPlaceHolder1_erroCadastro').hide();
    });

    var $campoConfirma = $('#ContentPlaceHolder1_confirma_senha');

    $campoConfirma.blur(function () {
        var $confirma = $campoConfirma.val();

        if ($confirma != $campoSenha.val() && $confirma != "") {
            $('#ContentPlaceHolder1_erroCadastro').fadeIn();
            $('#ContentPlaceHolder1_erroCadastro').children().text("Senhas diferentes");
        }
        else
            $('#ContentPlaceHolder1_erroCadastro').hide();

    });

});
