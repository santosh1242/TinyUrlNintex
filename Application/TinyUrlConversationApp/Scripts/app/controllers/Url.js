(function () {
    'use strict';
    // Define the controller name and assign the function.
    angular
        .module('TinyUrlConversationApp')
        .controller('UrlController', UrlController);

    // For minification. 
    // To ensure the parameters being injected to ProcessorController can still be accessible after minification.
    UrlController.$inject = ['ActivityProcess'];

    function UrlController(ActivityProcess) {
        var vm = this;
        vm.initialize = initialize;
        

        function initialize() {
            vm.message = '';
        }

        
    }
})();