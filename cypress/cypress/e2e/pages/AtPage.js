class page {
    elements = {
        formCNP: () => cy.get('#txtCNP'),
        formFirstName: () => cy.get('#txtFirstName'),
        formLastName: () => cy.get('#txtLastName'),
		formPhone: () => cy.get('#txtPhoneNumber'),
		formEmail: () => cy.get('#txtEmail'),
		formJob: () => cy.get('#txtJob'),
		formCompany: () => cy.get('#txtCompany'),
		formFloor: () => cy.get('#txtFloor'),
		formRoom: () => cy.get('#txtRoom'),
		formRFID: () => cy.get('#txtRFID'),
		formCounty: () => cy.get('#txtCounty'),
		formCity: () => cy.get('#txtCity'),
		formStreet: () => cy.get('#txtStreet'),
		formNumber: () => cy.get('#txtNumber'),

        submitButton: () => cy.get('#btnSave')
    }

    completeForm(cnp, firstName, lastName, phone, email, job, company, floor, room, rfid, county, city, street, number) {
        this.elements.formCNP().type(cnp)
        this.elements.formFirstName().type(firstName)
        this.elements.formLastName().type(lastName)
        this.elements.formPhone().type(phone)
        this.elements.formEmail().type(email)
        this.elements.formJob().type(job)
        this.elements.formCompany().type(company)
        this.elements.formFloor().type(floor)
        this.elements.formRoom().type(room)
        this.elements.formRFID().type(rfid)
        this.elements.formCounty().type(county)
        this.elements.formCity().type(city)
        this.elements.formStreet().type(street)
        this.elements.formNumber().type(number)
    }

    submitButton() {
        this.elements.submitButton().click();
    }
}

export default page;