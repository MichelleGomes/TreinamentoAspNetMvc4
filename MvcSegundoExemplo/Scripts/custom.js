function exibirMensagem(titulo, mensagem) {
    $('body').append('<div id="dialogomensagem"  titulo="mensagem" style="font-size: 75%;"></div>');
    $('#dialogomensagem').append(mensagem);
    $('#dialogomensagem').dialog({
        titulo: titulo,
        modal: true,
        width: 400,
        hight: 300,
        buttons: {
            ok: function () {
                $(this).dialog("close");
                $(this).remove();
            }

        }
    });
}