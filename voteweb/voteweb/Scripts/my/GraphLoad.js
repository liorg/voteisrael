
ang.controller("MainCtrl", function ($scope) {

    $scope.Survery = {
        SelectedDate: "2011-2-22",
        Current: {
            Id: '{E7BE131D-321F-4F84-A4D2-709C5C65E421}',
            Name: "דחף",
            Title: "דחף",
            LastDate: {
                Title: '2011-2-22',
                Items:
                    [
                        { Name: "ל", Val: 222 },
                        { Name: "ע", Val: 3 },
                        { Name: "x", Val: 33 },
                    ]

            },
            OtherDates: [
            {
                DateItem: {
                    Title: '2011-2-22',
                    Items:
                        [
                            { Name: "ל", Val: 222 },
                            { Name: "ע", Val: 3 },
                            { Name: "x", Val: 33 },
                        ]
                },
            },
            {
                DateItem: {
                    Title: '2011-1-1',
                    Items:
                                [
                                    { Name: "ל", Val: 432 },
                                    { Name: "ע", Val: 3 },
                                    { Name: "x", Val: 22 },
                                ]
                },


            },
            {
                DateItem: {
                    Title: '2091-1-1',
                    Items:
                                [
                                    { Name: "ל", Val: 1 },
                                    { Name: "ע", Val: 32 },
                                    { Name: "x", Val: 223 },
                                ]
                },

            }
            ],
        },
        AllItems: [
            { Id: 2, Name: "מינה צמח" },
            { Id: 3, Name: "גיאוקרטוגרפיה" },
            { Id: 4, Name: "מאגר מוחות" }
        ]
    };
    $scope.changeSurvery = function (s) {
        alert(s.Id)
    };
    $scope.otherDatePick = function (s) {
        alert(s.DateItem.Title);
        changeChartObject(s.DateItem);
        $scope.Survery.SelectedDate = s.DateItem.Title;
        refresh();
    };

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

   
    function changeChartObject(dateItem) {
        $scope.chartObject.options.title = dateItem.Title;
        $scope.chartObject.data.rows = [];
        for (row in dateItem.Items) {
            $scope.chartObject.data.rows.push({
                c: [
                   { v: dateItem.Items[row].Name },
                   { v: dateItem.Items[row].Val }
                ]
            })
        }
    };
    function loadChartObject() {
        $scope.chartObject.type = "ColumnChart";
        $scope.chartObject.options = { 'title': '' };
        $scope.chartObject.data = {
            "cols": [
                { id: "t", label: "Topping", type: "string" },
                { id: "s", label: "קולות", type: "number" }
            ],
            "rows": []
        };
        changeChartObject($scope.Survery.Current.LastDate);

    }

    function loadChartObjectx() {
        $scope.chartObject.data = {
            "cols": [
                { id: "t", label: "Topping", type: "string" },
                { id: "s", label: "קולות", type: "number" }
            ],
            "rows": [
                {
                    c: [
                       { v: "MMM" },
                       { v: 3 }
                    ]
                },
                { c: $scope.onions },

            ]
        };

        $scope.chartObject.type = "ColumnChart";
        $scope.chartObject.options = {
            'title': 'How Much Pizza I Ate Last Night'
        }
    }

    function refresh() {

        $scope.chart = $scope.chartObject;
    }
    loadChartObject();
    refresh();
    $scope.chart.cssStyle = style;
});
