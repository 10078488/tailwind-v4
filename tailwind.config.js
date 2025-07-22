/** @type {import('tailwindcss').Config} */
export default {
  content: [
    "./*.{html,js}" // This looks for .html and .js files in the root folder
  ],
  theme: {
    extend: {},
    screens: {
      'xs': '400px',  // custom breakpoint
      'sm': '640px',
      'md': '768px',
      'lg': '1024px',
      'xl': '1280px',
    },
  },
  plugins: [],
}