// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


// Modal popup functions
function showAlertModal(modalTitle, alertText){
    
    let modal = new bootstrap.Modal(document.getElementById('alert-modal'), {
    });
    modal.show();
    
    document.getElementById('alert-modal-title').innerHTML = modalTitle;
    document.getElementById('alert-modal-text').innerHTML = alertText;
}


function showConfirmModal(modalTitle, confirmText, confirmFunction){
    let modal = new bootstrap.Modal(document.getElementById('confirm-modal'), {
        
    });
    modal.show();

    document.getElementById('confirm-modal-title').innerHTML = modalTitle;
    document.getElementById('confirm-modal-text').innerHTML = confirmText;
    document.getElementById('confirm-modal-button').onclick = confirmFunction;
}