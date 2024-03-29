// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.




// Modal popup functions
function showAlertModal(modalTitle, alertText){
    
    let modal = new bootstrap.Modal(document.getElementById('alert-modal'), {
        keyboard: false
    });
    modal.show();
    
    let title = document.getElementById('alert-modal-title');
    let text = document.getElementById('alert-modal-text');
    
    title.innerHTML = modalTitle;
    text.innerHTML = alertText;
}
