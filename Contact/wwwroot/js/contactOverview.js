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
    
    
    // set contact id
    document.getElementById('contact-id').value = contactId;
}

function redirectToEditContact(){
    window.location = '/Contact/EditContact?contactId=' + document.getElementById('contact-id').value;
}

function deleteAllContacts(){
    $.ajax({
        url: '/Contact/DeleteAllContacts/',
        type: 'DELETE',
        data: {
            
        },
        success: function (data) {
            window.location.reload()
        },
        error: function (data) {
            showAlertModal('error', data);
        }
    });
}

function deletePrompt(contactId){
    showConfirmModal('Delete contact', 'Are you sure you want to delete this contact?', ()=>{
        $.ajax({
            url: '/Contact/DeleteContact/',
            type: 'DELETE',
            data: {
                contactId: contactId,
            },
            success: function (data) {
                if (data === 'ok'){
                    window.location.reload()
                }else {
                    showAlertModal('error', data);
                }

            },
            error: function (data) {
                showAlertModal('error', data);
                console.log('failed');
            }
        });
    })
}