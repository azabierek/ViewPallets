// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function changeLanguage() {

    const selectedLanguage = document.getElementById('languageSelect').value;

    const mainHeader = document.getElementById('mainH');
    const mainP = document.getElementById('mainP');
    const detailsH = document.getElementById('detailsH');
    const contentsH = document.getElementById('contentsH');
    const A = document.getElementById('A');
    const B = document.getElementById('B');
    const H = document.getElementById('H');
    const W = document.getElementById('W');
    const nameTh = document.getElementById('nameTh');
    const quantityTh = document.getElementById('quantityTh');
    const customerH = document.getElementById('customerH');
    const projectH = document.getElementById('projectH');
    const projectNameH = document.getElementById('projectNameH');

    if (selectedLanguage == 'PL') {
        if (mainHeader !== null) {
            mainHeader.innerText = 'NUMER PALETY PROSZĘ!';
            mainP.innerText = 'Powinieneś użyć urządzenia mobilnego i zeskanować kod QR zlokalizowany na etykiecie palety (prawy górny róg).';
        }
        if (detailsH !== null) {
            detailsH.innerText = 'SZCZEGÓŁY';
            contentsH.innerText = 'ZAWARTOŚĆ';
            A.innerText = 'DŁUGOŚĆ [mm]';
            B.innerText = 'SZEROKOŚĆ [mm]';
            H.innerText = 'WYSOKOŚĆ [mm]';
            W.innerText = 'WAGA [mm]';
            nameTh.innerText = 'NAZWA ELEMENTU';
            quantityTh.innerText = 'ILOŚĆ';
            customerH.innerText = 'ODBIORCA';
            projectH.innerText = 'IDENTYFIKATOR PROJEKTU';
            projectNameH.innerText = 'NAZWA PROJEKTU';

        }
    }
    else {
        if (mainHeader !== null) {
            mainHeader.innerText = 'PALLET NUMBER PLEASE!';
            mainP.innerText = 'You should use your mobile device to scan the QR code located on the pallet label (top right corner).';
        }
        if (detailsH !== null) {
            detailsH.innerText = 'DETAILS';
            contentsH.innerText = 'CONTENTS';
            A.innerText = 'LENGTH [mm]';
            B.innerText = 'WIDTH [mm]';
            H.innerText = 'HEIGHT [mm]';
            W.innerText = 'WEIGHT [mm]';
            nameTh.innerText = 'ITEM NAME';
            quantityTh.innerText = 'QUANTITY';
            customerH.innerText = 'CUSTOMER NAME';
            projectH.innerText = 'PROJECT ID';
            projectNameH.innerText = 'PROJECT NAME';
        }
    }
}