var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('KienTrucPhanMem');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);