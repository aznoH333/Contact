// user detail modal
function showContactDetailModal(name, phone, email, contactId){
    let modal = new bootstrap.Modal(document.getElementById('contact-detail-modal'), {
        keyboard: false
    });
    modal.show();

    // set text values
    let titleElement = document.getElementById('detail-modal-name');
    let phoneNumberElement = document.getElementById('detail-modal-phone-number');
    let emailElement = document.getElementById('detail-modal-email');

    titleElement.innerHTML = name
    phoneNumberElement.innerHTML = phone
    emailElement.innerHTML = email
    
    
    // set button attribute
    let editButton = document.getElementById('detail-modal-edit-button');
    editButton.setAttribute('asp-route-contactId', contactId)
}

