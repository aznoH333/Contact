function tryUpdateContact(updateFunction) {
    // get values
    let phoneNumber = document.getElementById('phone-number-input').value
    let email = document.getElementById('email-input').value

    // reset warnings
    let emailWarning = document.getElementById('email-warning')
    let phoneWarning = document.getElementById('phone-number-warning')
    let generalWarning  = document.getElementById('general-warning')
    emailWarning.classList.add('d-none')
    phoneWarning.classList.add('d-none')
    generalWarning.classList.add('d-none')

    $.ajax({
        url: '/Contact/IsContactValid/',
        type: 'POST',
        data: {
            email: email,
            phoneNumber: phoneNumber,
        },
        success: function (data) {
            // check results
            if (data.email === '' && data.phone === '' && data.general === '') {
                updateFunction()
            } else {
                // show error
                // email
                if (data.email !== '') {
                    emailWarning.classList.remove('d-none')
                    emailWarning.innerHTML = data.email
                }
                // phone number
                if (data.phone !== '') {
                    phoneWarning.classList.remove('d-none')
                    phoneWarning.innerHTML = data.phone
                }
                
                // general
                if (data.general !== ''){
                    generalWarning.classList.remove('d-none')
                    generalWarning.innerHTML = data.general
                }

            }

        },
        error: function (data) {
            showAlertModal(data)
            console.log('failed')
        }
    });
}

function updateContact() {
    let id = document.getElementById('contact-id').value;
    let firstName = document.getElementById('first-name-input').value;
    let lastName = document.getElementById('last-name-input').value;
    let email = document.getElementById('email-input').value;
    let phoneNumber = document.getElementById('phone-number-input').value;

    $.ajax({
        url: '/Contact/UpdateContact/',
        type: 'POST',
        data: {

            id: id,
            firstName: firstName,
            lastName: lastName,
            phoneNumber: phoneNumber,
            email: email,
            
        },
        success: function (data) {
            if (data == 'ok'){
                window.location.href = '/Contact/';
            }else {
                showAlertModal('error', data);
            }

        },
        error: function (data) {
            showAlertModal(data);
            console.log('failed');
        }
    });
}

function createNewContact() {
    let id = document.getElementById('contact-id').value;
    let firstName = document.getElementById('first-name-input').value;
    let lastName = document.getElementById('last-name-input').value;
    let email = document.getElementById('email-input').value;
    let phoneNumber = document.getElementById('phone-number-input').value;

    $.ajax({
        url: '/Contact/CreateNewContact/',
        type: 'POST',
        data: {

            id: id,
            firstName: firstName,
            lastName: lastName,
            phoneNumber: phoneNumber,
            email: email,

        },
        success: function (data) {
            if (data === 'ok'){
                window.location.href = '/Contact/';
            }else {
                showAlertModal('error', data);
            }

        },
        error: function (data) {
            showAlertModal('error', data);
            console.log('failed');
        }
    });
}

function deletePrompt(){
    showConfirmModal('Confirm', 'Are you sure you want to delete this contact?', deleteContact)
}

function deleteContact(){
    let id = document.getElementById('contact-id').value;
    $.ajax({
        url: '/Contact/DeleteContact/',
        type: 'DELETE',
        data: {
            contactId: id,
        },
        success: function (data) {
            if (data === 'ok'){
                window.location.href = '/Contact/';
            }else {
                showAlertModal('error', data);
            }

        },
        error: function (data) {
            showAlertModal('error', data);
            console.log('failed');
        }
    });
}


