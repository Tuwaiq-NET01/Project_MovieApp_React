import React from 'react'
import { useTranslation, Trans } from 'react-i18next'
const langs = {
  en: "English",
  ar: "Arabic",
  fr:"French"
}
export default function App() {
  const { i18n } = useTranslation()
  return (
    <center >
      <h2>
        <Trans i18nKey="welcome">
          Welcome
        </Trans>
      </h2>
      <h4>
        <Trans i18nKey="do">
          What do you want to do?
        </Trans>
      </h4>
      {Object.keys(langs).map((lang) => (
        <button className="btn btn-info"
          style={{ fontWeight: i18n.language === lang ? "bold" : "normal" }}
          onClick={() => i18n.changeLanguage(lang)}
        >{langs[lang]}
        </button>
      ))}<br></br>
         <img  src="https://i.pinimg.com/originals/1f/82/c9/1f82c992767ce8aeb6ef8b84a81a0eb2.gif"/>
    </center>


  )
}