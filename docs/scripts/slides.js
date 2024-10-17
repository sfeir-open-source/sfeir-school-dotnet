import { SfeirThemeInitializer } from '../web_modules/sfeir-school-theme/sfeir-school-theme.mjs';

// One method per module
function schoolSlides() {
  return ['00-school/00-TITLE.md', '00-school/speaker-jef.md', '00-school/01-intro.md'];
}

function introSlides() {
  return ['01-what_is_dotnet/00-TITLE.md'];
}

function gettingStartedSlides() {
  return ['02-getting_started/00-TITLE.md'];
}

function aspNetCoreSlides() {
  return ['03-aspnetcore/00-TITLE.md'];
}

function middlewaresSlides() {
  return ['04-middlewares/00-TITLE.md']
}

function entityFrameworkSlides() {
  return ['05-entity-framework/00-TITLE.md']
}

function communicationSlides() {
  return ['06-communication/00-TITLE.md']
}

function conclusionSlides() {
  return ['07-conclusion/00-TITLE.md']
}

function formation() {
  return [
    //
    ...schoolSlides(), //
    ...introSlides(), //
    ...gettingStartedSlides(), //
    ...aspNetCoreSlides(), //
    ...middlewaresSlides(), //
    ...entityFrameworkSlides(), //
    ...communicationSlides(), //
    ...conclusionSlides() //
  ].map((slidePath) => {
    return { path: slidePath };
  });
}

SfeirThemeInitializer.init(formation);
