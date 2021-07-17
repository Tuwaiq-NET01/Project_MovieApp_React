import i18n from 'i18next'
import { initReactI18next } from 'react-i18next'
import languageDetector from 'i18next-browser-languagedetector'
i18n.use(initReactI18next).use(languageDetector).init({
    resources: {
        en: {
            translation: {
                welcome: "Hi",
                do: "What do you want to see from the movies?"
            }
        },
        ar: {
            translation: {
                welcome: "مرحبًا",
                do: "ماذا تريد أن تشاهد من الأفلام؟"
            }
        },
        fr: {
            translation: {
                welcome: "Bonjour",
                do: "Que veux-tu voir dans les films ?"
            }
        }
    }
})
export default i18n