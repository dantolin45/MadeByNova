// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function GetDescripcion(idarticulo)
{
    $.ajax({
        url: '/Home/InfoArticulo',
        data: { idarticulo: idarticulo}, 
        type: 'GET',
        dataType : 'json',
        success : function(response){
                $("#ModalTitle").html("Comprar: " + response.nombre);
                $("#modalbody").html("Comprar: " + response.idarticulo);
                
                
               
        }
    });
}




/* form */
 


function GetDescripcion(idarticulo)
{
    $.ajax({
        url: '/Home/InfoArticulo',
        data: { idarticulo: idarticulo}, 
        type: 'GET',
        dataType : 'json',
        success : function(response){
                $("#ModalTitle").html("Comprar: " + response.nombre);
                $("#modalbody").html("Comprar: " + response.idarticulo);
                
                
               
        }
    });
}


const openModal = document.querySelector('.btn');
const modal = document.querySelector('.modal');
const closeModal = document.querySelector('.modal__close');

openModal.addEventListener('click', (e)=>{
    e.preventDefault();
    modal.classList.add('modal--show');
});

closeModal.addEventListener('click', (e)=>{
    e.preventDefault();
    modal.classList.remove('modal--show');
});