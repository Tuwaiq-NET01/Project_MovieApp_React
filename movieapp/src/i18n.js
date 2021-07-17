import i18n from 'i18next'
import { initReactI18next } from 'react-i18next'
import languageDetector from 'i18next-browser-languagedetector'

i18n.use(initReactI18next).use(languageDetector).init({
    resources: {
        en: {
            translation: {
                welcome: "Hi",
                do: "What do  you want to do?"
            }
        },
        ar:{
            translation: {
                welcome: "مرحباً",
                do: "ماذا تريد ان تفعل؟"
            }
        }
    }
})

export default i18n