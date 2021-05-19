
/***busca um endereço pelo cep****/

$(document).ready(function () {
	
});


/*
$.ajax({
    type: 'POST',
    url: '/Questionario/ObterPorPalavraChave',
    data: { Palavra: $("#txtPalavraChave").val(), idUsuario: getCookie("token", 0) },
    success: function (result) {
        if (result != null && result.length > 0) {
            PreencherTabela(result);
        }
        else {
            bootbox.alert("Nenhum questionário encontrado.");
        }
        $("#divLoading").hide(300);
    },
    error: 
    }
});




