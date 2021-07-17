import React from 'react'
import { useTranslation, Trans } from 'react-i18next'

const langs = {
    en: "English",
    ar: "Arabic"
}
export default function Home() {
    const { i18n } = useTranslation()
  return (
    <center>
      <h2>
        <Trans i18nKey="welcome">
        Welcome to movie App
        </Trans>
      </h2>
      <h4>
        <Trans i18nKey="do">
        Watch your favorite movies now
        </Trans>
      </h4>
      {Object.keys(langs).map((lang) => (
        <button
          onClick={() => i18n.changeLanguage(lang)}
        >{langs[lang]}
        </button>
      ))}
      <br/>
      <img style={{height:200}} src="https://cdn.dribbble.com/users/1568191/screenshots/3468993/videezy2.gif" />
    </center>
  )
}


