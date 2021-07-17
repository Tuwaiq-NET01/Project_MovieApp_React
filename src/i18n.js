import i18n from "i18next";
import { initReactI18next } from "react-i18next";
import languageDetector from "i18next-browser-languagedetector";
i18n
  .use(initReactI18next)
  .use(languageDetector)
  .init({
    resources: {
      en: {
        translation: {
          Search: "Search",
        },
      },
      ar: {
        translation: {
          Search: "بحث",
        },
      },
    },
  });
export default i18n;
