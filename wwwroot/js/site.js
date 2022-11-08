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


const openModal = document.querySelector('#btnS');
const openModals = document.querySelector('#btnSe');
const modal = document.querySelector('.modal');
const modale = document.querySelector('.modale');
const closeModal = document.querySelector('.modal__close');
const closeModale = document.querySelector('.modal__close');

openModal.addEventListener('click', (e)=>{
    e.preventDefault();
    modal.classList.add('modal--show');
});

openModals.addEventListener('click', (e)=>{
    e.preventDefault();
    modale.classList.add('modal--show');
});

closeModal.addEventListener('click', (e)=>{
    e.preventDefault();
    modal.classList.remove('modal--show');
});

closeModale.addEventListener('click', (e)=>{
    e.preventDefault();
    modale.classList.remove('modal--show');
});