
ang.controller("MainCtrl", function ($scope) {


    $scope.Survery = {
        Current: {
            Id: 1,
            Name: "דחף"
        },
        AllItems: [
            { Id: 2, Name: "מינה צמח" },
            { Id: 3, Name: "גיאוקרטוגרפיה" },
            { Id: 4, Name: "מאגר מוחות" }
        ]

    };
    $scope.changeSurvery = function (s)
    {
        alert(1);
        alert(s.Id)
    };

    $scope.items = [
    'The first choice!',
    'And another choice for you.',
    'but wait! A third!'
    ];

    $scope.status = {
        isopen: false
    };

    $scope.toggled = function (open) {
        $log.log('Dropdown is now: ', open);
    };

    $scope.toggleDropdown = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();
        $scope.status.isopen = !$scope.status.isopen;
    };
    $scope.chartObject = {};
    var style = "padding:0;height:400px";
    $scope.onions = [
        { v: "Onions" }, { v: 3 }
    ];

    $scope.chartObject.data = {
        "cols": [
            { id: "t", label: "Topping", type: "string" },
            { id: "s", label: "קולות", type: "number" }
        ], "rows": [
            {
                c: [
                   { v: "MMM" },
                   { v: 3 }
                ]
            },
            { c: $scope.onions },

        ]
    };

    $scope.chartObject.type = "ColumnChart";// $routeParams.chartType;
    $scope.chartObject.options = {
        'title': 'How Much Pizza I Ate Last Night'
    }

    $scope.chart = $scope.chartObject;
    $scope.chart.cssStyle = style;
});
