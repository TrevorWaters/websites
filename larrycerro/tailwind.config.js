module.exports = {
  purge: {
    content: ["./Pages/**/*.razor", "./**/*.html", "./Shared/**/*.razor"],
  },
  darkMode: false, // or 'media' or 'class'
  theme: {
    extend: {
      backgroundImage: theme => ({
        'hero-pattern': "url('\assets\images\guyisinrafters.jpeg')"
       })
    },
  },
  variants: {
    extend: {},
  },
  plugins: [

    require('@tailwindcss/typography'),
  ],
}
