using Agiles.Hangman.Model.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using TechTalk.SpecFlow;

namespace Agiles.Hangman.UITests
{
    [Binding]
    public class HangmanSteps
    {
        private IWebDriver _driver;
        private string _baseURL;
        private Partida _partida;

        [BeforeScenario]
        public void TestInitialize()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + @"\Drivers";
            _driver = new InternetExplorerDriver(path);
            _baseURL = "http://localhost:13916/";
        }

        [Given(@"the word code auriculares")]
        public void GivenTheWordCodeAuriculares()
        {
            _partida = new Partida(new Palabra("auriculares"), 6);
            _driver.Navigate().GoToUrl(_baseURL);
            var btnJugar = _driver.FindElement(By.Id("btnJugar"));
            btnJugar.SendKeys(Keys.Enter);
        }
        
        [When(@"I input the letter a")]
        public void WhenIInputTheLetterA()
        {
            var txtLetra = _driver.FindElement(By.Id("txtLetra"));
            var btnProbar = _driver.FindElement(By.Id("btnProbar"));
            for (int i = 0; i < 7; i++)
            {
                txtLetra.SendKeys("a");
                btnProbar.SendKeys(Keys.Enter);
            }
        }

        [Then(@"I should have guessed two letters")]
        public void ThenIShouldBeToldThatILost()
        {
            var lblLetrasIngresadas = _driver.FindElement(By.Id("lblLetrasIngresadas"));
            var palabra = _driver.FindElement(By.Id("palabra"));
            Assert.IsTrue(lblLetrasIngresadas.Text.Contains("a") && palabra.Text.Contains("a"));
        }

        //[When(@"I input the entire word code casa")]
        //public void WhenIInputTheEntireWordCodeCasa()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Then(@"the result should be Felicitaciones Ganaste! =D")]
        //public void ThenTheResultShouldBeFelicitacionesGanasteD()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Then(@"the result should be one letter guessed and one letter in the inputs")]
        //public void ThenTheResultShouldBeOneLetterGuessedAndOneLetterInTheInputs()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Then(@"the result should be Que mal, perdiste! D=")]
        //public void ThenTheResultShouldBeQueMalPerdisteD()
        //{
        //    ScenarioContext.Current.Pending();
        //}


        //[When(@"I input the entire word code auriculares")]
        //public void WhenIInputTheEntireWordCodeAuriculares()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [AfterScenario]
        public void TestCleanUp()
        {
            _driver.Quit();
        }
    }
}
