/*! tailwindcss v4.1.11 | MIT License | https://tailwindcss.com */
@layer properties;
@layer theme, base, components, utilities;
@layer theme {
  :root, :host {
    --font-sans: ui-sans-serif, system-ui, sans-serif, 'Apple Color Emoji', 'Segoe UI Emoji', 'Segoe UI Symbol',
    'Noto Color Emoji';
    --font-mono: ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, 'Liberation Mono', 'Courier New',
    monospace;
    --color-black: #000;
    --color-white: #fff;
    --spacing: 0.25rem;
    --text-sm: 0.875rem;
    --text-sm--line-height: calc(1.25 / 0.875);
    --text-xl: 1.25rem;
    --text-xl--line-height: calc(1.75 / 1.25);
    --text-2xl: 1.5rem;
    --text-2xl--line-height: calc(2 / 1.5);
    --text-3xl: 1.875rem;
    --text-3xl--line-height: calc(2.25 / 1.875);
    --text-5xl: 3rem;
    --text-5xl--line-height: 1;
    --font-weight-light: 300;
    --font-weight-normal: 400;
    --font-weight-medium: 500;
    --font-weight-semibold: 600;
    --font-weight-bold: 700;
    --leading-normal: 1.5;
    --default-font-family: var(--font-sans);
    --default-mono-font-family: var(--font-mono);
  }
}
@layer base {
  *, ::after, ::before, ::backdrop, ::file-selector-button {
    box-sizing: border-box;
    margin: 0;
    padding: 0;
    border: 0 solid;
  }
  html, :host {
    line-height: 1.5;
    -webkit-text-size-adjust: 100%;
    tab-size: 4;
    font-family: var(--default-font-family, ui-sans-serif, system-ui, sans-serif, 'Apple Color Emoji', 'Segoe UI Emoji', 'Segoe UI Symbol', 'Noto Color Emoji');
    font-feature-settings: var(--default-font-feature-settings, normal);
    font-variation-settings: var(--default-font-variation-settings, normal);
    -webkit-tap-highlight-color: transparent;
  }
  hr {
    height: 0;
    color: inherit;
    border-top-width: 1px;
  }
  abbr:where([title]) {
    -webkit-text-decoration: underline dotted;
    text-decoration: underline dotted;
  }
  h1, h2, h3, h4, h5, h6 {
    font-size: inherit;
    font-weight: inherit;
  }
  a {
    color: inherit;
    -webkit-text-decoration: inherit;
    text-decoration: inherit;
  }
  b, strong {
    font-weight: bolder;
  }
  code, kbd, samp, pre {
    font-family: var(--default-mono-font-family, ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, 'Liberation Mono', 'Courier New', monospace);
    font-feature-settings: var(--default-mono-font-feature-settings, normal);
    font-variation-settings: var(--default-mono-font-variation-settings, normal);
    font-size: 1em;
  }
  small {
    font-size: 80%;
  }
  sub, sup {
    font-size: 75%;
    line-height: 0;
    position: relative;
    vertical-align: baseline;
  }
  sub {
    bottom: -0.25em;
  }
  sup {
    top: -0.5em;
  }
  table {
    text-indent: 0;
    border-color: inherit;
    border-collapse: collapse;
  }
  :-moz-focusring {
    outline: auto;
  }
  progress {
    vertical-align: baseline;
  }
  summary {
    display: list-item;
  }
  ol, ul, menu {
    list-style: none;
  }
  img, svg, video, canvas, audio, iframe, embed, object {
    display: block;
    vertical-align: middle;
  }
  img, video {
    max-width: 100%;
    height: auto;
  }
  button, input, select, optgroup, textarea, ::file-selector-button {
    font: inherit;
    font-feature-settings: inherit;
    font-variation-settings: inherit;
    letter-spacing: inherit;
    color: inherit;
    border-radius: 0;
    background-color: transparent;
    opacity: 1;
  }
  :where(select:is([multiple], [size])) optgroup {
    font-weight: bolder;
  }
  :where(select:is([multiple], [size])) optgroup option {
    padding-inline-start: 20px;
  }
  ::file-selector-button {
    margin-inline-end: 4px;
  }
  ::placeholder {
    opacity: 1;
  }
  @supports (not (-webkit-appearance: -apple-pay-button))  or (contain-intrinsic-size: 1px) {
    ::placeholder {
      color: currentcolor;
      @supports (color: color-mix(in lab, red, red)) {
        color: color-mix(in oklab, currentcolor 50%, transparent);
      }
    }
  }
  textarea {
    resize: vertical;
  }
  ::-webkit-search-decoration {
    -webkit-appearance: none;
  }
  ::-webkit-date-and-time-value {
    min-height: 1lh;
    text-align: inherit;
  }
  ::-webkit-datetime-edit {
    display: inline-flex;
  }
  ::-webkit-datetime-edit-fields-wrapper {
    padding: 0;
  }
  ::-webkit-datetime-edit, ::-webkit-datetime-edit-year-field, ::-webkit-datetime-edit-month-field, ::-webkit-datetime-edit-day-field, ::-webkit-datetime-edit-hour-field, ::-webkit-datetime-edit-minute-field, ::-webkit-datetime-edit-second-field, ::-webkit-datetime-edit-millisecond-field, ::-webkit-datetime-edit-meridiem-field {
    padding-block: 0;
  }
  :-moz-ui-invalid {
    box-shadow: none;
  }
  button, input:where([type='button'], [type='reset'], [type='submit']), ::file-selector-button {
    appearance: button;
  }
  ::-webkit-inner-spin-button, ::-webkit-outer-spin-button {
    height: auto;
  }
  [hidden]:where(:not([hidden='until-found'])) {
    display: none !important;
  }
}
@layer utilities {
  .absolute {
    position: absolute;
  }
  .fixed {
    position: fixed;
  }
  .relative {
    position: relative;
  }
  .inset-0 {
    inset: calc(var(--spacing) * 0);
  }
  .top-0 {
    top: calc(var(--spacing) * 0);
  }
  .top-2\.5 {
    top: calc(var(--spacing) * 2.5);
  }
  .top-3\.5 {
    top: calc(var(--spacing) * 3.5);
  }
  .top-\[41px\] {
    top: 41px;
  }
  .top-\[80px\] {
    top: 80px;
  }
  .top-\[83px\] {
    top: 83px;
  }
  .top-\[236px\] {
    top: 236px;
  }
  .top-\[300px\] {
    top: 300px;
  }
  .top-\[450px\] {
    top: 450px;
  }
  .right-0 {
    right: calc(var(--spacing) * 0);
  }
  .right-2\.5 {
    right: calc(var(--spacing) * 2.5);
  }
  .right-4 {
    right: calc(var(--spacing) * 4);
  }
  .left-0 {
    left: calc(var(--spacing) * 0);
  }
  .left-2\.5 {
    left: calc(var(--spacing) * 2.5);
  }
  .left-4 {
    left: calc(var(--spacing) * 4);
  }
  .left-\[10px\] {
    left: 10px;
  }
  .left-\[14px\] {
    left: 14px;
  }
  .left-\[120px\] {
    left: 120px;
  }
  .left-\[250px\] {
    left: 250px;
  }
  .z-20 {
    z-index: 20;
  }
  .mt-1 {
    margin-top: calc(var(--spacing) * 1);
  }
  .mt-2\.5 {
    margin-top: calc(var(--spacing) * 2.5);
  }
  .mt-5 {
    margin-top: calc(var(--spacing) * 5);
  }
  .mt-\[8px\] {
    margin-top: 8px;
  }
  .mt-\[10px\] {
    margin-top: 10px;
  }
  .mt-\[20px\] {
    margin-top: 20px;
  }
  .mb-1\.5 {
    margin-bottom: calc(var(--spacing) * 1.5);
  }
  .mb-2 {
    margin-bottom: calc(var(--spacing) * 2);
  }
  .mb-2\.5 {
    margin-bottom: calc(var(--spacing) * 2.5);
  }
  .mb-\[8px\] {
    margin-bottom: 8px;
  }
  .block {
    display: block;
  }
  .flex {
    display: flex;
  }
  .grid {
    display: grid;
  }
  .hidden {
    display: none;
  }
  .inline-block {
    display: inline-block;
  }
  .h-4 {
    height: calc(var(--spacing) * 4);
  }
  .h-4\/5 {
    height: calc(4/5 * 100%);
  }
  .h-6 {
    height: calc(var(--spacing) * 6);
  }
  .h-\[13px\] {
    height: 13px;
  }
  .h-\[18\.35px\] {
    height: 18.35px;
  }
  .h-\[21px\] {
    height: 21px;
  }
  .h-\[22px\] {
    height: 22px;
  }
  .h-\[23px\] {
    height: 23px;
  }
  .h-\[24px\] {
    height: 24px;
  }
  .h-\[29px\] {
    height: 29px;
  }
  .h-\[30px\] {
    height: 30px;
  }
  .h-\[32\.5px\] {
    height: 32.5px;
  }
  .h-\[32px\] {
    height: 32px;
  }
  .h-\[36px\] {
    height: 36px;
  }
  .h-\[39px\] {
    height: 39px;
  }
  .h-\[40px\] {
    height: 40px;
  }
  .h-\[42px\] {
    height: 42px;
  }
  .h-\[50px\] {
    height: 50px;
  }
  .h-\[71px\] {
    height: 71px;
  }
  .h-\[80px\] {
    height: 80px;
  }
  .h-\[120px\] {
    height: 120px;
  }
  .h-\[130px\] {
    height: 130px;
  }
  .h-\[162px\] {
    height: 162px;
  }
  .h-\[165px\] {
    height: 165px;
  }
  .h-\[235px\] {
    height: 235px;
  }
  .h-\[243px\] {
    height: 243px;
  }
  .h-\[263px\] {
    height: 263px;
  }
  .h-\[270px\] {
    height: 270px;
  }
  .h-\[293px\] {
    height: 293px;
  }
  .h-\[334px\] {
    height: 334px;
  }
  .h-\[400px\] {
    height: 400px;
  }
  .h-\[408px\] {
    height: 408px;
  }
  .h-\[450px\] {
    height: 450px;
  }
  .h-\[455px\] {
    height: 455px;
  }
  .h-\[496px\] {
    height: 496px;
  }
  .h-\[500px\] {
    height: 500px;
  }
  .h-\[512px\] {
    height: 512px;
  }
  .h-\[600px\] {
    height: 600px;
  }
  .h-\[612px\] {
    height: 612px;
  }
  .h-\[765px\] {
    height: 765px;
  }
  .h-\[913px\] {
    height: 913px;
  }
  .h-dvh {
    height: 100dvh;
  }
  .h-full {
    height: 100%;
  }
  .min-h-\[186\.84px\] {
    min-height: 186.84px;
  }
  .min-h-\[342px\] {
    min-height: 342px;
  }
  .min-h-full {
    min-height: 100%;
  }
  .w-1\/2 {
    width: calc(1/2 * 100%);
  }
  .w-4 {
    width: calc(var(--spacing) * 4);
  }
  .w-6 {
    width: calc(var(--spacing) * 6);
  }
  .w-\[12\%\] {
    width: 12%;
  }
  .w-\[13px\] {
    width: 13px;
  }
  .w-\[20px\] {
    width: 20px;
  }
  .w-\[30px\] {
    width: 30px;
  }
  .w-\[35px\] {
    width: 35px;
  }
  .w-\[38px\] {
    width: 38px;
  }
  .w-\[49\%\] {
    width: 49%;
  }
  .w-\[54px\] {
    width: 54px;
  }
  .w-\[56px\] {
    width: 56px;
  }
  .w-\[68px\] {
    width: 68px;
  }
  .w-\[80px\] {
    width: 80px;
  }
  .w-\[110px\] {
    width: 110px;
  }
  .w-\[114\.13px\] {
    width: 114.13px;
  }
  .w-\[130px\] {
    width: 130px;
  }
  .w-\[132px\] {
    width: 132px;
  }
  .w-\[147px\] {
    width: 147px;
  }
  .w-\[152px\] {
    width: 152px;
  }
  .w-\[160px\] {
    width: 160px;
  }
  .w-\[165px\] {
    width: 165px;
  }
  .w-\[187px\] {
    width: 187px;
  }
  .w-\[189px\] {
    width: 189px;
  }
  .w-\[195px\] {
    width: 195px;
  }
  .w-\[300px\] {
    width: 300px;
  }
  .w-\[310px\] {
    width: 310px;
  }
  .w-full {
    width: 100%;
  }
  .max-w-\[828\.5px\] {
    max-width: 828.5px;
  }
  .max-w-full {
    max-width: 100%;
  }
  .min-w-72 {
    min-width: calc(var(--spacing) * 72);
  }
  .min-w-80 {
    min-width: calc(var(--spacing) * 80);
  }
  .min-w-\[74px\] {
    min-width: 74px;
  }
  .min-w-\[86\.52\%\] {
    min-width: 86.52%;
  }
  .min-w-\[140px\] {
    min-width: 140px;
  }
  .min-w-\[145px\] {
    min-width: 145px;
  }
  .min-w-\[147px\] {
    min-width: 147px;
  }
  .min-w-\[148px\] {
    min-width: 148px;
  }
  .min-w-\[150px\] {
    min-width: 150px;
  }
  .min-w-\[160px\] {
    min-width: 160px;
  }
  .min-w-\[300px\] {
    min-width: 300px;
  }
  .min-w-\[320px\] {
    min-width: 320px;
  }
  .min-w-full {
    min-width: 100%;
  }
  .grid-cols-1 {
    grid-template-columns: repeat(1, minmax(0, 1fr));
  }
  .flex-col {
    flex-direction: column;
  }
  .flex-wrap {
    flex-wrap: wrap;
  }
  .content-center {
    align-content: center;
  }
  .items-center {
    align-items: center;
  }
  .items-start {
    align-items: flex-start;
  }
  .justify-between {
    justify-content: space-between;
  }
  .justify-center {
    justify-content: center;
  }
  .justify-end {
    justify-content: flex-end;
  }
  .justify-start {
    justify-content: flex-start;
  }
  .gap-2 {
    gap: calc(var(--spacing) * 2);
  }
  .gap-2\.5 {
    gap: calc(var(--spacing) * 2.5);
  }
  .gap-\[5px\] {
    gap: 5px;
  }
  .gap-\[6px\] {
    gap: 6px;
  }
  .place-self-start {
    place-self: start;
  }
  .self-center {
    align-self: center;
  }
  .self-end {
    align-self: flex-end;
  }
  .justify-self-center {
    justify-self: center;
  }
  .justify-self-stretch {
    justify-self: stretch;
  }
  .rounded-full {
    border-radius: calc(infinity * 1px);
  }
  .bg-\[\#0c0c0c\] {
    background-color: #0c0c0c;
  }
  .bg-\[\#7DC3EB\] {
    background-color: #7DC3EB;
  }
  .bg-\[\#748C70\] {
    background-color: #748C70;
  }
  .bg-\[\#748c70\] {
    background-color: #748c70;
  }
  .bg-\[\#19418e\] {
    background-color: #19418e;
  }
  .bg-\[\#404040\] {
    background-color: #404040;
  }
  .bg-\[\#909225\] {
    background-color: #909225;
  }
  .bg-\[\#d0a5ea\] {
    background-color: #d0a5ea;
  }
  .bg-\[\#fee5e4\] {
    background-color: #fee5e4;
  }
  .bg-\[\#fff\] {
    background-color: #fff;
  }
  .bg-black {
    background-color: var(--color-black);
  }
  .bg-white {
    background-color: var(--color-white);
  }
  .object-cover {
    object-fit: cover;
  }
  .object-\[-250px\] {
    object-position: -250px;
  }
  .px-2 {
    padding-inline: calc(var(--spacing) * 2);
  }
  .px-2\.5 {
    padding-inline: calc(var(--spacing) * 2.5);
  }
  .px-\[10px\] {
    padding-inline: 10px;
  }
  .px-\[110px\] {
    padding-inline: 110px;
  }
  .text-center {
    text-align: center;
  }
  .font-\[\#272F25\] {
    font-family: #272F25;
  }
  .text-sm {
    font-size: var(--text-sm);
    line-height: var(--tw-leading, var(--text-sm--line-height));
  }
  .text-xl {
    font-size: var(--text-xl);
    line-height: var(--tw-leading, var(--text-xl--line-height));
  }
  .text-\[10px\] {
    font-size: 10px;
  }
  .text-\[12px\] {
    font-size: 12px;
  }
  .text-\[14px\] {
    font-size: 14px;
  }
  .text-\[15px\] {
    font-size: 15px;
  }
  .text-\[16px\] {
    font-size: 16px;
  }
  .text-\[18px\] {
    font-size: 18px;
  }
  .text-\[20px\] {
    font-size: 20px;
  }
  .leading-5 {
    --tw-leading: calc(var(--spacing) * 5);
    line-height: calc(var(--spacing) * 5);
  }
  .leading-\[1\.8\] {
    --tw-leading: 1.8;
    line-height: 1.8;
  }
  .leading-\[140\%\] {
    --tw-leading: 140%;
    line-height: 140%;
  }
  .leading-normal {
    --tw-leading: var(--leading-normal);
    line-height: var(--leading-normal);
  }
  .font-bold {
    --tw-font-weight: var(--font-weight-bold);
    font-weight: var(--font-weight-bold);
  }
  .font-light {
    --tw-font-weight: var(--font-weight-light);
    font-weight: var(--font-weight-light);
  }
  .font-medium {
    --tw-font-weight: var(--font-weight-medium);
    font-weight: var(--font-weight-medium);
  }
  .font-normal {
    --tw-font-weight: var(--font-weight-normal);
    font-weight: var(--font-weight-normal);
  }
  .font-semibold {
    --tw-font-weight: var(--font-weight-semibold);
    font-weight: var(--font-weight-semibold);
  }
  .text-\[\#D1D9CF\] {
    color: #D1D9CF;
  }
  .text-\[\#fa6d57\] {
    color: #fa6d57;
  }
  .text-black {
    color: var(--color-black);
  }
  .text-white {
    color: var(--color-white);
  }
  .italic {
    font-style: italic;
  }
  .drop-shadow-\[0_4px_0\.75px_rgba\(0\,0\,0\,0\.08\)\] {
    --tw-drop-shadow-size: drop-shadow(0 4px 0.75px var(--tw-drop-shadow-color, rgba(0,0,0,0.08)));
    --tw-drop-shadow: var(--tw-drop-shadow-size);
    filter: var(--tw-blur,) var(--tw-brightness,) var(--tw-contrast,) var(--tw-grayscale,) var(--tw-hue-rotate,) var(--tw-invert,) var(--tw-saturate,) var(--tw-sepia,) var(--tw-drop-shadow,);
  }
  .drop-shadow-\[0_4px_0\.75px_rgba\(0\,0\,0\,0\.09\)\] {
    --tw-drop-shadow-size: drop-shadow(0 4px 0.75px var(--tw-drop-shadow-color, rgba(0,0,0,0.09)));
    --tw-drop-shadow: var(--tw-drop-shadow-size);
    filter: var(--tw-blur,) var(--tw-brightness,) var(--tw-contrast,) var(--tw-grayscale,) var(--tw-hue-rotate,) var(--tw-invert,) var(--tw-saturate,) var(--tw-sepia,) var(--tw-drop-shadow,);
  }
  .sm\:top-\[34px\] {
    @media (width >= 40rem) {
      top: 34px;
    }
  }
  .sm\:top-\[81px\] {
    @media (width >= 40rem) {
      top: 81px;
    }
  }
  .sm\:top-\[541px\] {
    @media (width >= 40rem) {
      top: 541px;
    }
  }
  .sm\:right-\[18px\] {
    @media (width >= 40rem) {
      right: 18px;
    }
  }
  .sm\:left-6 {
    @media (width >= 40rem) {
      left: calc(var(--spacing) * 6);
    }
  }
  .sm\:left-\[0px\] {
    @media (width >= 40rem) {
      left: 0px;
    }
  }
  .sm\:left-\[15px\] {
    @media (width >= 40rem) {
      left: 15px;
    }
  }
  .sm\:left-\[332px\] {
    @media (width >= 40rem) {
      left: 332px;
    }
  }
  .sm\:flex {
    @media (width >= 40rem) {
      display: flex;
    }
  }
  .sm\:h-\[18px\] {
    @media (width >= 40rem) {
      height: 18px;
    }
  }
  .sm\:h-\[24px\] {
    @media (width >= 40rem) {
      height: 24px;
    }
  }
  .sm\:h-\[55px\] {
    @media (width >= 40rem) {
      height: 55px;
    }
  }
  .sm\:h-\[80px\] {
    @media (width >= 40rem) {
      height: 80px;
    }
  }
  .sm\:h-\[279px\] {
    @media (width >= 40rem) {
      height: 279px;
    }
  }
  .sm\:h-\[325px\] {
    @media (width >= 40rem) {
      height: 325px;
    }
  }
  .sm\:h-\[350px\] {
    @media (width >= 40rem) {
      height: 350px;
    }
  }
  .sm\:h-\[487px\] {
    @media (width >= 40rem) {
      height: 487px;
    }
  }
  .sm\:h-\[512px\] {
    @media (width >= 40rem) {
      height: 512px;
    }
  }
  .sm\:h-\[540px\] {
    @media (width >= 40rem) {
      height: 540px;
    }
  }
  .sm\:h-\[577px\] {
    @media (width >= 40rem) {
      height: 577px;
    }
  }
  .sm\:h-\[670px\] {
    @media (width >= 40rem) {
      height: 670px;
    }
  }
  .sm\:h-\[755px\] {
    @media (width >= 40rem) {
      height: 755px;
    }
  }
  .sm\:h-\[917px\] {
    @media (width >= 40rem) {
      height: 917px;
    }
  }
  .sm\:w-\[32\.66666667\%\] {
    @media (width >= 40rem) {
      width: 32.66666667%;
    }
  }
  .sm\:w-\[50px\] {
    @media (width >= 40rem) {
      width: 50px;
    }
  }
  .sm\:w-\[132px\] {
    @media (width >= 40rem) {
      width: 132px;
    }
  }
  .sm\:w-\[193px\] {
    @media (width >= 40rem) {
      width: 193px;
    }
  }
  .sm\:w-full {
    @media (width >= 40rem) {
      width: 100%;
    }
  }
  .sm\:object-center {
    @media (width >= 40rem) {
      object-position: center;
    }
  }
  .sm\:px-\[30px\] {
    @media (width >= 40rem) {
      padding-inline: 30px;
    }
  }
  .sm\:text-\[14px\] {
    @media (width >= 40rem) {
      font-size: 14px;
    }
  }
  .sm\:text-\[16px\] {
    @media (width >= 40rem) {
      font-size: 16px;
    }
  }
  .md\:top-\[18px\] {
    @media (width >= 48rem) {
      top: 18px;
    }
  }
  .md\:top-\[90px\] {
    @media (width >= 48rem) {
      top: 90px;
    }
  }
  .md\:top-\[265px\] {
    @media (width >= 48rem) {
      top: 265px;
    }
  }
  .md\:left-\[41px\] {
    @media (width >= 48rem) {
      left: 41px;
    }
  }
  .md\:left-\[455px\] {
    @media (width >= 48rem) {
      left: 455px;
    }
  }
  .md\:flex {
    @media (width >= 48rem) {
      display: flex;
    }
  }
  .md\:hidden {
    @media (width >= 48rem) {
      display: none;
    }
  }
  .md\:h-6 {
    @media (width >= 48rem) {
      height: calc(var(--spacing) * 6);
    }
  }
  .md\:h-\[24px\] {
    @media (width >= 48rem) {
      height: 24px;
    }
  }
  .md\:h-\[30px\] {
    @media (width >= 48rem) {
      height: 30px;
    }
  }
  .md\:h-\[40px\] {
    @media (width >= 48rem) {
      height: 40px;
    }
  }
  .md\:h-\[46px\] {
    @media (width >= 48rem) {
      height: 46px;
    }
  }
  .md\:h-\[80px\] {
    @media (width >= 48rem) {
      height: 80px;
    }
  }
  .md\:h-\[110px\] {
    @media (width >= 48rem) {
      height: 110px;
    }
  }
  .md\:h-\[350px\] {
    @media (width >= 48rem) {
      height: 350px;
    }
  }
  .md\:h-\[356px\] {
    @media (width >= 48rem) {
      height: 356px;
    }
  }
  .md\:h-\[411px\] {
    @media (width >= 48rem) {
      height: 411px;
    }
  }
  .md\:h-\[528px\] {
    @media (width >= 48rem) {
      height: 528px;
    }
  }
  .md\:h-\[573px\] {
    @media (width >= 48rem) {
      height: 573px;
    }
  }
  .md\:h-\[711px\] {
    @media (width >= 48rem) {
      height: 711px;
    }
  }
  .md\:h-\[806\.63\] {
    @media (width >= 48rem) {
      height: 806.63;
    }
  }
  .md\:h-\[972px\] {
    @media (width >= 48rem) {
      height: 972px;
    }
  }
  .md\:w-\[160px\] {
    @media (width >= 48rem) {
      width: 160px;
    }
  }
  .md\:w-\[184px\] {
    @media (width >= 48rem) {
      width: 184px;
    }
  }
  .md\:w-\[226px\] {
    @media (width >= 48rem) {
      width: 226px;
    }
  }
  .md\:w-\[250px\] {
    @media (width >= 48rem) {
      width: 250px;
    }
  }
  .md\:w-\[316\.37px\] {
    @media (width >= 48rem) {
      width: 316.37px;
    }
  }
  .md\:w-auto {
    @media (width >= 48rem) {
      width: auto;
    }
  }
  .md\:w-full {
    @media (width >= 48rem) {
      width: 100%;
    }
  }
  .md\:justify-between {
    @media (width >= 48rem) {
      justify-content: space-between;
    }
  }
  .md\:self-end {
    @media (width >= 48rem) {
      align-self: flex-end;
    }
  }
  .md\:object-contain {
    @media (width >= 48rem) {
      object-fit: contain;
    }
  }
  .md\:p-2 {
    @media (width >= 48rem) {
      padding: calc(var(--spacing) * 2);
    }
  }
  .md\:px-\[30px\] {
    @media (width >= 48rem) {
      padding-inline: 30px;
    }
  }
  .md\:text-\[12px\] {
    @media (width >= 48rem) {
      font-size: 12px;
    }
  }
  .md\:text-\[24px\] {
    @media (width >= 48rem) {
      font-size: 24px;
    }
  }
  .lg\:top-\[21px\] {
    @media (width >= 64rem) {
      top: 21px;
    }
  }
  .lg\:top-\[25px\] {
    @media (width >= 64rem) {
      top: 25px;
    }
  }
  .lg\:top-\[90px\] {
    @media (width >= 64rem) {
      top: 90px;
    }
  }
  .lg\:top-\[130px\] {
    @media (width >= 64rem) {
      top: 130px;
    }
  }
  .lg\:top-\[315px\] {
    @media (width >= 64rem) {
      top: 315px;
    }
  }
  .lg\:top-\[316px\] {
    @media (width >= 64rem) {
      top: 316px;
    }
  }
  .lg\:top-\[326px\] {
    @media (width >= 64rem) {
      top: 326px;
    }
  }
  .lg\:top-\[440px\] {
    @media (width >= 64rem) {
      top: 440px;
    }
  }
  .lg\:top-\[485px\] {
    @media (width >= 64rem) {
      top: 485px;
    }
  }
  .lg\:top-\[493px\] {
    @media (width >= 64rem) {
      top: 493px;
    }
  }
  .lg\:left-\[36px\] {
    @media (width >= 64rem) {
      left: 36px;
    }
  }
  .lg\:left-\[110px\] {
    @media (width >= 64rem) {
      left: 110px;
    }
  }
  .lg\:left-\[174px\] {
    @media (width >= 64rem) {
      left: 174px;
    }
  }
  .lg\:left-\[186px\] {
    @media (width >= 64rem) {
      left: 186px;
    }
  }
  .lg\:left-\[210px\] {
    @media (width >= 64rem) {
      left: 210px;
    }
  }
  .lg\:left-\[550px\] {
    @media (width >= 64rem) {
      left: 550px;
    }
  }
  .lg\:mt-0 {
    @media (width >= 64rem) {
      margin-top: calc(var(--spacing) * 0);
    }
  }
  .lg\:hidden {
    @media (width >= 64rem) {
      display: none;
    }
  }
  .lg\:h-6 {
    @media (width >= 64rem) {
      height: calc(var(--spacing) * 6);
    }
  }
  .lg\:h-8 {
    @media (width >= 64rem) {
      height: calc(var(--spacing) * 8);
    }
  }
  .lg\:h-\[22px\] {
    @media (width >= 64rem) {
      height: 22px;
    }
  }
  .lg\:h-\[24px\] {
    @media (width >= 64rem) {
      height: 24px;
    }
  }
  .lg\:h-\[32px\] {
    @media (width >= 64rem) {
      height: 32px;
    }
  }
  .lg\:h-\[40px\] {
    @media (width >= 64rem) {
      height: 40px;
    }
  }
  .lg\:h-\[48px\] {
    @media (width >= 64rem) {
      height: 48px;
    }
  }
  .lg\:h-\[80px\] {
    @media (width >= 64rem) {
      height: 80px;
    }
  }
  .lg\:h-\[91px\] {
    @media (width >= 64rem) {
      height: 91px;
    }
  }
  .lg\:h-\[102px\] {
    @media (width >= 64rem) {
      height: 102px;
    }
  }
  .lg\:h-\[112px\] {
    @media (width >= 64rem) {
      height: 112px;
    }
  }
  .lg\:h-\[130px\] {
    @media (width >= 64rem) {
      height: 130px;
    }
  }
  .lg\:h-\[150px\] {
    @media (width >= 64rem) {
      height: 150px;
    }
  }
  .lg\:h-\[170px\] {
    @media (width >= 64rem) {
      height: 170px;
    }
  }
  .lg\:h-\[204px\] {
    @media (width >= 64rem) {
      height: 204px;
    }
  }
  .lg\:h-\[284px\] {
    @media (width >= 64rem) {
      height: 284px;
    }
  }
  .lg\:h-\[371px\] {
    @media (width >= 64rem) {
      height: 371px;
    }
  }
  .lg\:h-\[375px\] {
    @media (width >= 64rem) {
      height: 375px;
    }
  }
  .lg\:h-\[411px\] {
    @media (width >= 64rem) {
      height: 411px;
    }
  }
  .lg\:h-\[413px\] {
    @media (width >= 64rem) {
      height: 413px;
    }
  }
  .lg\:h-\[438px\] {
    @media (width >= 64rem) {
      height: 438px;
    }
  }
  .lg\:h-\[540px\] {
    @media (width >= 64rem) {
      height: 540px;
    }
  }
  .lg\:h-\[544px\] {
    @media (width >= 64rem) {
      height: 544px;
    }
  }
  .lg\:h-\[546px\] {
    @media (width >= 64rem) {
      height: 546px;
    }
  }
  .lg\:h-\[573px\] {
    @media (width >= 64rem) {
      height: 573px;
    }
  }
  .lg\:h-\[593px\] {
    @media (width >= 64rem) {
      height: 593px;
    }
  }
  .lg\:h-\[600px\] {
    @media (width >= 64rem) {
      height: 600px;
    }
  }
  .lg\:h-\[631px\] {
    @media (width >= 64rem) {
      height: 631px;
    }
  }
  .lg\:h-\[705px\] {
    @media (width >= 64rem) {
      height: 705px;
    }
  }
  .lg\:h-\[771px\] {
    @media (width >= 64rem) {
      height: 771px;
    }
  }
  .lg\:h-\[923px\] {
    @media (width >= 64rem) {
      height: 923px;
    }
  }
  .lg\:h-\[977px\] {
    @media (width >= 64rem) {
      height: 977px;
    }
  }
  .lg\:h-\[1157px\] {
    @media (width >= 64rem) {
      height: 1157px;
    }
  }
  .lg\:w-6 {
    @media (width >= 64rem) {
      width: calc(var(--spacing) * 6);
    }
  }
  .lg\:w-\[60px\] {
    @media (width >= 64rem) {
      width: 60px;
    }
  }
  .lg\:w-\[86px\] {
    @media (width >= 64rem) {
      width: 86px;
    }
  }
  .lg\:w-\[88\.73px\] {
    @media (width >= 64rem) {
      width: 88.73px;
    }
  }
  .lg\:w-\[133\.08px\] {
    @media (width >= 64rem) {
      width: 133.08px;
    }
  }
  .lg\:w-\[160px\] {
    @media (width >= 64rem) {
      width: 160px;
    }
  }
  .lg\:w-\[167px\] {
    @media (width >= 64rem) {
      width: 167px;
    }
  }
  .lg\:w-\[184px\] {
    @media (width >= 64rem) {
      width: 184px;
    }
  }
  .lg\:w-\[208px\] {
    @media (width >= 64rem) {
      width: 208px;
    }
  }
  .lg\:w-\[240px\] {
    @media (width >= 64rem) {
      width: 240px;
    }
  }
  .lg\:w-\[249px\] {
    @media (width >= 64rem) {
      width: 249px;
    }
  }
  .lg\:w-\[295px\] {
    @media (width >= 64rem) {
      width: 295px;
    }
  }
  .lg\:w-\[418\.49px\] {
    @media (width >= 64rem) {
      width: 418.49px;
    }
  }
  .lg\:w-\[453px\] {
    @media (width >= 64rem) {
      width: 453px;
    }
  }
  .lg\:w-\[470px\] {
    @media (width >= 64rem) {
      width: 470px;
    }
  }
  .lg\:w-\[496px\] {
    @media (width >= 64rem) {
      width: 496px;
    }
  }
  .lg\:w-\[623px\] {
    @media (width >= 64rem) {
      width: 623px;
    }
  }
  .lg\:w-\[auto\] {
    @media (width >= 64rem) {
      width: auto;
    }
  }
  .lg\:w-full {
    @media (width >= 64rem) {
      width: 100%;
    }
  }
  .lg\:justify-center {
    @media (width >= 64rem) {
      justify-content: center;
    }
  }
  .lg\:gap-6 {
    @media (width >= 64rem) {
      gap: calc(var(--spacing) * 6);
    }
  }
  .lg\:p-2 {
    @media (width >= 64rem) {
      padding: calc(var(--spacing) * 2);
    }
  }
  .lg\:px-\[110px\] {
    @media (width >= 64rem) {
      padding-inline: 110px;
    }
  }
  .lg\:pt-5 {
    @media (width >= 64rem) {
      padding-top: calc(var(--spacing) * 5);
    }
  }
  .lg\:text-xl {
    @media (width >= 64rem) {
      font-size: var(--text-xl);
      line-height: var(--tw-leading, var(--text-xl--line-height));
    }
  }
  .lg\:text-\[14px\] {
    @media (width >= 64rem) {
      font-size: 14px;
    }
  }
  .lg\:text-\[16px\] {
    @media (width >= 64rem) {
      font-size: 16px;
    }
  }
  .lg\:text-\[20px\] {
    @media (width >= 64rem) {
      font-size: 20px;
    }
  }
  .lg\:text-\[28px\] {
    @media (width >= 64rem) {
      font-size: 28px;
    }
  }
  .lg\:text-\[32px\] {
    @media (width >= 64rem) {
      font-size: 32px;
    }
  }
  .lg\:leading-10 {
    @media (width >= 64rem) {
      --tw-leading: calc(var(--spacing) * 10);
      line-height: calc(var(--spacing) * 10);
    }
  }
  .xl\:top-\[6px\] {
    @media (width >= 80rem) {
      top: 6px;
    }
  }
  .xl\:top-\[26px\] {
    @media (width >= 80rem) {
      top: 26px;
    }
  }
  .xl\:top-\[85px\] {
    @media (width >= 80rem) {
      top: 85px;
    }
  }
  .xl\:top-\[131px\] {
    @media (width >= 80rem) {
      top: 131px;
    }
  }
  .xl\:top-\[360px\] {
    @media (width >= 80rem) {
      top: 360px;
    }
  }
  .xl\:top-\[395px\] {
    @media (width >= 80rem) {
      top: 395px;
    }
  }
  .xl\:top-\[396px\] {
    @media (width >= 80rem) {
      top: 396px;
    }
  }
  .xl\:top-\[440px\] {
    @media (width >= 80rem) {
      top: 440px;
    }
  }
  .xl\:top-\[780px\] {
    @media (width >= 80rem) {
      top: 780px;
    }
  }
  .xl\:right-0 {
    @media (width >= 80rem) {
      right: calc(var(--spacing) * 0);
    }
  }
  .xl\:left-3 {
    @media (width >= 80rem) {
      left: calc(var(--spacing) * 3);
    }
  }
  .xl\:left-3\.5 {
    @media (width >= 80rem) {
      left: calc(var(--spacing) * 3.5);
    }
  }
  .xl\:left-\[14px\] {
    @media (width >= 80rem) {
      left: 14px;
    }
  }
  .xl\:left-\[24px\] {
    @media (width >= 80rem) {
      left: 24px;
    }
  }
  .xl\:left-\[180px\] {
    @media (width >= 80rem) {
      left: 180px;
    }
  }
  .xl\:left-\[410px\] {
    @media (width >= 80rem) {
      left: 410px;
    }
  }
  .xl\:left-\[836px\] {
    @media (width >= 80rem) {
      left: 836px;
    }
  }
  .xl\:flex {
    @media (width >= 80rem) {
      display: flex;
    }
  }
  .xl\:h-\[22px\] {
    @media (width >= 80rem) {
      height: 22px;
    }
  }
  .xl\:h-\[28px\] {
    @media (width >= 80rem) {
      height: 28px;
    }
  }
  .xl\:h-\[40px\] {
    @media (width >= 80rem) {
      height: 40px;
    }
  }
  .xl\:h-\[55px\] {
    @media (width >= 80rem) {
      height: 55px;
    }
  }
  .xl\:h-\[130px\] {
    @media (width >= 80rem) {
      height: 130px;
    }
  }
  .xl\:h-\[230px\] {
    @media (width >= 80rem) {
      height: 230px;
    }
  }
  .xl\:h-\[356px\] {
    @media (width >= 80rem) {
      height: 356px;
    }
  }
  .xl\:h-\[411px\] {
    @media (width >= 80rem) {
      height: 411px;
    }
  }
  .xl\:h-\[417px\] {
    @media (width >= 80rem) {
      height: 417px;
    }
  }
  .xl\:h-\[455px\] {
    @media (width >= 80rem) {
      height: 455px;
    }
  }
  .xl\:h-\[800px\] {
    @media (width >= 80rem) {
      height: 800px;
    }
  }
  .xl\:h-\[814px\] {
    @media (width >= 80rem) {
      height: 814px;
    }
  }
  .xl\:h-\[840px\] {
    @media (width >= 80rem) {
      height: 840px;
    }
  }
  .xl\:h-\[972\.85px\] {
    @media (width >= 80rem) {
      height: 972.85px;
    }
  }
  .xl\:h-\[1419px\] {
    @media (width >= 80rem) {
      height: 1419px;
    }
  }
  .xl\:h-\[1599px\] {
    @media (width >= 80rem) {
      height: 1599px;
    }
  }
  .xl\:w-\[18\.0455\%\%\] {
    @media (width >= 80rem) {
      width: 18.0455%%;
    }
  }
  .xl\:w-\[18\.0455\%\] {
    @media (width >= 80rem) {
      width: 18.0455%;
    }
  }
  .xl\:w-\[60px\] {
    @media (width >= 80rem) {
      width: 60px;
    }
  }
  .xl\:w-\[88px\] {
    @media (width >= 80rem) {
      width: 88px;
    }
  }
  .xl\:w-\[132px\] {
    @media (width >= 80rem) {
      width: 132px;
    }
  }
  .xl\:w-\[184px\] {
    @media (width >= 80rem) {
      width: 184px;
    }
  }
  .xl\:w-\[200px\] {
    @media (width >= 80rem) {
      width: 200px;
    }
  }
  .xl\:w-\[392px\] {
    @media (width >= 80rem) {
      width: 392px;
    }
  }
  .xl\:w-\[452px\] {
    @media (width >= 80rem) {
      width: 452px;
    }
  }
  .xl\:w-\[495px\] {
    @media (width >= 80rem) {
      width: 495px;
    }
  }
  .xl\:w-\[748px\] {
    @media (width >= 80rem) {
      width: 748px;
    }
  }
  .xl\:w-full {
    @media (width >= 80rem) {
      width: 100%;
    }
  }
  .xl\:grid-cols-2 {
    @media (width >= 80rem) {
      grid-template-columns: repeat(2, minmax(0, 1fr));
    }
  }
  .xl\:justify-between {
    @media (width >= 80rem) {
      justify-content: space-between;
    }
  }
  .xl\:gap-\[70px\] {
    @media (width >= 80rem) {
      gap: 70px;
    }
  }
  .xl\:justify-self-center {
    @media (width >= 80rem) {
      justify-self: center;
    }
  }
  .xl\:px-0 {
    @media (width >= 80rem) {
      padding-inline: calc(var(--spacing) * 0);
    }
  }
  .xl\:px-\[110px\] {
    @media (width >= 80rem) {
      padding-inline: 110px;
    }
  }
  .xl\:pl-\[110px\] {
    @media (width >= 80rem) {
      padding-left: 110px;
    }
  }
  .xl\:text-\[20px\] {
    @media (width >= 80rem) {
      font-size: 20px;
    }
  }
  .xl\:text-\[22px\] {
    @media (width >= 80rem) {
      font-size: 22px;
    }
  }
  .xl\:text-\[34px\] {
    @media (width >= 80rem) {
      font-size: 34px;
    }
  }
  .xl\:font-semibold {
    @media (width >= 80rem) {
      --tw-font-weight: var(--font-weight-semibold);
      font-weight: var(--font-weight-semibold);
    }
  }
  .\32 xl\:top-\[220px\] {
    @media (width >= 96rem) {
      top: 220px;
    }
  }
  .\32 xl\:top-\[300px\] {
    @media (width >= 96rem) {
      top: 300px;
    }
  }
  .\32 xl\:top-\[430px\] {
    @media (width >= 96rem) {
      top: 430px;
    }
  }
  .\32 xl\:top-\[470px\] {
    @media (width >= 96rem) {
      top: 470px;
    }
  }
  .\32 xl\:top-\[480px\] {
    @media (width >= 96rem) {
      top: 480px;
    }
  }
  .\32 xl\:top-\[815px\] {
    @media (width >= 96rem) {
      top: 815px;
    }
  }
  .\32 xl\:left-\[180px\] {
    @media (width >= 96rem) {
      left: 180px;
    }
  }
  .\32 xl\:left-\[630px\] {
    @media (width >= 96rem) {
      left: 630px;
    }
  }
  .\32 xl\:left-\[2000px\] {
    @media (width >= 96rem) {
      left: 2000px;
    }
  }
  .\32 xl\:flex {
    @media (width >= 96rem) {
      display: flex;
    }
  }
  .\32 xl\:hidden {
    @media (width >= 96rem) {
      display: none;
    }
  }
  .\32 xl\:h-\[26px\] {
    @media (width >= 96rem) {
      height: 26px;
    }
  }
  .\32 xl\:h-\[30px\] {
    @media (width >= 96rem) {
      height: 30px;
    }
  }
  .\32 xl\:h-\[40px\] {
    @media (width >= 96rem) {
      height: 40px;
    }
  }
  .\32 xl\:h-\[48px\] {
    @media (width >= 96rem) {
      height: 48px;
    }
  }
  .\32 xl\:h-\[50px\] {
    @media (width >= 96rem) {
      height: 50px;
    }
  }
  .\32 xl\:h-\[78px\] {
    @media (width >= 96rem) {
      height: 78px;
    }
  }
  .\32 xl\:h-\[87\.5px\] {
    @media (width >= 96rem) {
      height: 87.5px;
    }
  }
  .\32 xl\:h-\[90px\] {
    @media (width >= 96rem) {
      height: 90px;
    }
  }
  .\32 xl\:h-\[100px\] {
    @media (width >= 96rem) {
      height: 100px;
    }
  }
  .\32 xl\:h-\[120px\] {
    @media (width >= 96rem) {
      height: 120px;
    }
  }
  .\32 xl\:h-\[150px\] {
    @media (width >= 96rem) {
      height: 150px;
    }
  }
  .\32 xl\:h-\[170px\] {
    @media (width >= 96rem) {
      height: 170px;
    }
  }
  .\32 xl\:h-\[197px\] {
    @media (width >= 96rem) {
      height: 197px;
    }
  }
  .\32 xl\:h-\[200px\] {
    @media (width >= 96rem) {
      height: 200px;
    }
  }
  .\32 xl\:h-\[300px\] {
    @media (width >= 96rem) {
      height: 300px;
    }
  }
  .\32 xl\:h-\[500px\] {
    @media (width >= 96rem) {
      height: 500px;
    }
  }
  .\32 xl\:h-\[546px\] {
    @media (width >= 96rem) {
      height: 546px;
    }
  }
  .\32 xl\:h-\[550px\] {
    @media (width >= 96rem) {
      height: 550px;
    }
  }
  .\32 xl\:h-\[650px\] {
    @media (width >= 96rem) {
      height: 650px;
    }
  }
  .\32 xl\:h-\[743px\] {
    @media (width >= 96rem) {
      height: 743px;
    }
  }
  .\32 xl\:h-\[923px\] {
    @media (width >= 96rem) {
      height: 923px;
    }
  }
  .\32 xl\:h-\[1000px\] {
    @media (width >= 96rem) {
      height: 1000px;
    }
  }
  .\32 xl\:h-\[1060px\] {
    @media (width >= 96rem) {
      height: 1060px;
    }
  }
  .\32 xl\:h-\[1450px\] {
    @media (width >= 96rem) {
      height: 1450px;
    }
  }
  .\32 xl\:h-\[1484px\] {
    @media (width >= 96rem) {
      height: 1484px;
    }
  }
  .\32 xl\:h-\[1732px\] {
    @media (width >= 96rem) {
      height: 1732px;
    }
  }
  .\32 xl\:h-\[1912px\] {
    @media (width >= 96rem) {
      height: 1912px;
    }
  }
  .\32 xl\:h-full {
    @media (width >= 96rem) {
      height: 100%;
    }
  }
  .\32 xl\:w-\[26px\] {
    @media (width >= 96rem) {
      width: 26px;
    }
  }
  .\32 xl\:w-\[30px\] {
    @media (width >= 96rem) {
      width: 30px;
    }
  }
  .\32 xl\:w-\[80px\] {
    @media (width >= 96rem) {
      width: 80px;
    }
  }
  .\32 xl\:w-\[92px\] {
    @media (width >= 96rem) {
      width: 92px;
    }
  }
  .\32 xl\:w-\[120px\] {
    @media (width >= 96rem) {
      width: 120px;
    }
  }
  .\32 xl\:w-\[148px\] {
    @media (width >= 96rem) {
      width: 148px;
    }
  }
  .\32 xl\:w-\[220px\] {
    @media (width >= 96rem) {
      width: 220px;
    }
  }
  .\32 xl\:w-\[228px\] {
    @media (width >= 96rem) {
      width: 228px;
    }
  }
  .\32 xl\:w-\[256px\] {
    @media (width >= 96rem) {
      width: 256px;
    }
  }
  .\32 xl\:w-\[270px\] {
    @media (width >= 96rem) {
      width: 270px;
    }
  }
  .\32 xl\:w-\[300px\] {
    @media (width >= 96rem) {
      width: 300px;
    }
  }
  .\32 xl\:w-\[350px\] {
    @media (width >= 96rem) {
      width: 350px;
    }
  }
  .\32 xl\:w-\[360px\] {
    @media (width >= 96rem) {
      width: 360px;
    }
  }
  .\32 xl\:w-\[400px\] {
    @media (width >= 96rem) {
      width: 400px;
    }
  }
  .\32 xl\:w-\[450px\] {
    @media (width >= 96rem) {
      width: 450px;
    }
  }
  .\32 xl\:w-\[500px\] {
    @media (width >= 96rem) {
      width: 500px;
    }
  }
  .\32 xl\:w-\[550px\] {
    @media (width >= 96rem) {
      width: 550px;
    }
  }
  .\32 xl\:w-\[1100px\] {
    @media (width >= 96rem) {
      width: 1100px;
    }
  }
  .\32 xl\:w-\[2140px\] {
    @media (width >= 96rem) {
      width: 2140px;
    }
  }
  .\32 xl\:w-full {
    @media (width >= 96rem) {
      width: 100%;
    }
  }
  .\32 xl\:justify-between {
    @media (width >= 96rem) {
      justify-content: space-between;
    }
  }
  .\32 xl\:justify-evenly {
    @media (width >= 96rem) {
      justify-content: space-evenly;
    }
  }
  .\32 xl\:justify-self-center {
    @media (width >= 96rem) {
      justify-self: center;
    }
  }
  .\32 xl\:p-2 {
    @media (width >= 96rem) {
      padding: calc(var(--spacing) * 2);
    }
  }
  .\32 xl\:p-5 {
    @media (width >= 96rem) {
      padding: calc(var(--spacing) * 5);
    }
  }
  .\32 xl\:px-0 {
    @media (width >= 96rem) {
      padding-inline: calc(var(--spacing) * 0);
    }
  }
  .\32 xl\:px-80 {
    @media (width >= 96rem) {
      padding-inline: calc(var(--spacing) * 80);
    }
  }
  .\32 xl\:pt-\[44px\] {
    @media (width >= 96rem) {
      padding-top: 44px;
    }
  }
  .\32 xl\:pr-\[15px\] {
    @media (width >= 96rem) {
      padding-right: 15px;
    }
  }
  .\32 xl\:text-2xl {
    @media (width >= 96rem) {
      font-size: var(--text-2xl);
      line-height: var(--tw-leading, var(--text-2xl--line-height));
    }
  }
  .\32 xl\:text-3xl {
    @media (width >= 96rem) {
      font-size: var(--text-3xl);
      line-height: var(--tw-leading, var(--text-3xl--line-height));
    }
  }
  .\32 xl\:text-5xl {
    @media (width >= 96rem) {
      font-size: var(--text-5xl);
      line-height: var(--tw-leading, var(--text-5xl--line-height));
    }
  }
  .\32 xl\:text-xl {
    @media (width >= 96rem) {
      font-size: var(--text-xl);
      line-height: var(--tw-leading, var(--text-xl--line-height));
    }
  }
  .\32 xl\:text-\[20px\] {
    @media (width >= 96rem) {
      font-size: 20px;
    }
  }
  .\32 xl\:text-\[32px\] {
    @media (width >= 96rem) {
      font-size: 32px;
    }
  }
  .\32 xl\:text-\[34px\] {
    @media (width >= 96rem) {
      font-size: 34px;
    }
  }
  .\32 xl\:text-\[38px\] {
    @media (width >= 96rem) {
      font-size: 38px;
    }
  }
  .\32 xl\:text-\[40px\] {
    @media (width >= 96rem) {
      font-size: 40px;
    }
  }
}
@property --tw-leading {
  syntax: "*";
  inherits: false;
}
@property --tw-font-weight {
  syntax: "*";
  inherits: false;
}
@property --tw-blur {
  syntax: "*";
  inherits: false;
}
@property --tw-brightness {
  syntax: "*";
  inherits: false;
}
@property --tw-contrast {
  syntax: "*";
  inherits: false;
}
@property --tw-grayscale {
  syntax: "*";
  inherits: false;
}
@property --tw-hue-rotate {
  syntax: "*";
  inherits: false;
}
@property --tw-invert {
  syntax: "*";
  inherits: false;
}
@property --tw-opacity {
  syntax: "*";
  inherits: false;
}
@property --tw-saturate {
  syntax: "*";
  inherits: false;
}
@property --tw-sepia {
  syntax: "*";
  inherits: false;
}
@property --tw-drop-shadow {
  syntax: "*";
  inherits: false;
}
@property --tw-drop-shadow-color {
  syntax: "*";
  inherits: false;
}
@property --tw-drop-shadow-alpha {
  syntax: "<percentage>";
  inherits: false;
  initial-value: 100%;
}
@property --tw-drop-shadow-size {
  syntax: "*";
  inherits: false;
}
@layer properties {
  @supports ((-webkit-hyphens: none) and (not (margin-trim: inline))) or ((-moz-orient: inline) and (not (color:rgb(from red r g b)))) {
    *, ::before, ::after, ::backdrop {
      --tw-leading: initial;
      --tw-font-weight: initial;
      --tw-blur: initial;
      --tw-brightness: initial;
      --tw-contrast: initial;
      --tw-grayscale: initial;
      --tw-hue-rotate: initial;
      --tw-invert: initial;
      --tw-opacity: initial;
      --tw-saturate: initial;
      --tw-sepia: initial;
      --tw-drop-shadow: initial;
      --tw-drop-shadow-color: initial;
      --tw-drop-shadow-alpha: 100%;
      --tw-drop-shadow-size: initial;
    }
  }
}
