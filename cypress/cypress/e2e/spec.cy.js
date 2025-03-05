import AtPage from "./pages/AtPage"

describe('Testare pagina de inserare date pacienti', () => {

    const atPage = new AtPage();
    beforeEach(() => {
        cy.visit('http://localhost:1935/InsertData.aspx')
    })

    it('Verificare CNP', () => {
        cy.viewport(1920, 1080)
        atPage.completeForm(
            '500',
            'Aleznauer',
            'Albert',
            '0731763841',
            'albert.aleznauer@student.upt.com',
            'SW Dev',
            'Continental',
            '1',
            '1',
            'R0013FE43',
            'Timis',
            'Timisoara',
            'Gheorghe Ivanescu',
            '53-57'
        )
        atPage.submitButton()
        cy.get("#lblErrorMessage").should('have.text', 'CNP should have exactly 13 characters.')
    })

    it('Verificare cifre numar de telefon', () => {
        cy.viewport(1920, 1080)
        atPage.completeForm(
            '5001223668822',
            'Aleznauer',
            'Albert',
            '0731761',
            'albert.aleznauer@student.upt.com',
            'SW Dev',
            'Continental',
            '1',
            '1',
            'R0013FE43',
            'Timis',
            'Timisoara',
            'Gheorghe Ivanescu',
            '53-57'
        )
        atPage.submitButton()
        cy.get("#lblErrorMessage").should('have.text', 'Phone number should have exactly 10 digits.')
    })

    it('Verificare mail', () => {
        cy.viewport(1920, 1080)
        atPage.completeForm(
            '5001223668822',
            'Aleznauer',
            'Albert',
            '0731763841',
            'albert.aleznauer',
            'SW Dev',
            'Continental',
            '1',
            '1',
            'R0013FE43',
            'Timis',
            'Timisoara',
            'Gheorghe Ivanescu',
            '53-57'
        )
        atPage.submitButton()
        cy.get("#lblErrorMessage").should('have.text', 'Invalid email!')
    })

    it.only('Verificare request API', () => {
        cy.viewport(1920, 1080)
        atPage.completeForm(
            '5011276673823',
            'albert',
            'mircea',
            '0721763841',
            'albert.mircea@gmail.com',
            'SW Dev',
            'Continental',
            '1',
            '1',
            'R0013FE43',
            'Timis',
            'Timisoara',
            'Gheorghe Ivanescu',
            '53-57'
        )
        
        cy.intercept({
            url: 'http://localhost:1935/**',
            method: 'POST'
        }).as('messageRequest')

        atPage.submitButton()

        cy.get('@messageRequest').its('response.statusCode').should('eq', 200)
    })

})