const colors = require('tailwindcss/colors')

module.exports = {
  purge: {
    content: ["./Pages/**/*.razor", "./**/*.html", "./Shared/**/*.razor"],
  },
  darkMode: false, // or 'media' or 'class'
  theme: {
    extend: {
      colors: {
        lime: colors.lime,
        warmGray: colors.warmGray,
        lightBlue: colors.lightBlue
      }
/*       backgroundImage: theme => ({
        'hero-pattern': "url('\assets\images\guyisinrafters.jpeg')"
       }) */
    },
  },
  variants: {
    extend: {
    }
  },
  plugins: [],
}
