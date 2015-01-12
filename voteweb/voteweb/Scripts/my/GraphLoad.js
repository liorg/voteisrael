
ang.controller("MainCtrl", function ($scope) {
    $scope.chartObject = {};

    var style = "padding:2px;height:400px";
    var logo = [
        { Name: "Maariv", Url: "http://upload.wikimedia.org/wikipedia/he/c/ce/Maariv.svg" },
        { Name: "Walla", Url: "http://upload.wikimedia.org/wikipedia/he/d/d5/Walla_logo.svg" },
        { Name: "Mako", Url: "http://upload.wikimedia.org/wikipedia/he/2/2a/New_mako.png" },
        { Name: "Arutz_7", Url: "http://upload.wikimedia.org/wikipedia/he/3/3f/Arutz_7.png" },
        { Name: "Glz", Url: "http://upload.wikimedia.org/wikipedia/he/4/4a/Glzlogo.jpg" },
        { Name: "Haaretz", Url: "http://upload.wikimedia.org/wikipedia/he/9/92/Haaretz.svg" },
        { Name: "10", Url: "http://upload.wikimedia.org/wikipedia/he/2/28/%D7%9C%D7%95%D7%92%D7%95_%D7%97%D7%93%D7%A9%D7%95%D7%AA_10_%D7%94%D7%97%D7%93%D7%A9.png" },
        { Name: "Ynet", Url: "http://upload.wikimedia.org/wikipedia/he/f/fa/YnetLogo.svg" },
        { Name: "Bet", Url: "http://upload.wikimedia.org/wikipedia/he/3/31/ReshetBetLogo.jpg" }

    ];

    $scope.Survery = {
        SelectedSurvery:{
            SelectedDate: "d",
            Links:[],
            Remarks:[]
        },
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
                    ],
                Links:
                    [
                        { Name: "הארץ", Ico: "http://upload.wikimedia.org/wikipedia/he/3/3f/Arutz_7.png", Desc: "נלקח מהארץ", Url: "" },
                        { Name: "ערוץ 10", Ico: "http://upload.wikimedia.org/wikipedia/he/2/28/%D7%9C%D7%95%D7%92%D7%95_%D7%97%D7%93%D7%A9%D7%95%D7%AA_10_%D7%94%D7%97%D7%93%D7%A9.png", Desc: "10נלקח מ", Url: "" },
                        { Name: "רשת ב", Ico: "http://upload.wikimedia.org/wikipedia/he/3/31/ReshetBetLogo.jpg", Desc: "נלקח מרשת ב", Url: "" },
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
                    ,
                    Links:
                        [
                            { Name: "ערוץ 7", Ico: "http://upload.wikimedia.org/wikipedia/he/3/3f/Arutz_7.png", Desc: "ערוץ 7", Url: "" },
                            { Name: "מעריב", Ico: "http://upload.wikimedia.org/wikipedia/he/c/ce/Maariv.svg", Desc: "נלקח מעריב", Url: "" },
                            { Name: "רשת ב", Ico: "http://upload.wikimedia.org/wikipedia/he/3/31/ReshetBetLogo.jpg", Desc: "נלקח מרשת ב", Url: "" },
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
                    ,
                    Links:
                        [
                            { Name: "הארץ", Ico: "http://upload.wikimedia.org/wikipedia/he/9/92/Haaretz.svg", Desc: "נלקח מהארץ", Url: "" },

                            { Name: "WALLA", Ico: "http://upload.wikimedia.org/wikipedia/he/d/d5/Walla_logo.svg", Desc: "נלקח מ WALLA", Url: "" },
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
                                ],
                    Links:
                        [
                            { Name: "ערוץ 10", Ico: "ל", Desc: "נלקח מערץ 10", Url: "" },
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
        changeChartObject(s.DateItem);
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

    function changeChartObject(dateItem) {
        $scope.Survery.SelectedSurvery.SelectedDate =dateItem.Title;
        $scope.Survery.SelectedSurvery.Links = dateItem.Links;
        $scope.chartObject.options.title = dateItem.Title;
        $scope.chartObject.data.rows = [];
        for (row in dateItem.Items) {
            $scope.chartObject.data.rows.push({
                c: [
                   { v: dateItem.Items[row].Name },
                   { v: dateItem.Items[row].Val}
                ]
            })
        }
    };

    function loadChartObject() {
        $scope.chartObject.type = "ColumnChart";
        $scope.chartObject.options = { 'title': '' };
        $scope.chartObject.data = {
            "cols": [
                { id: "t", label: "Topping", type: "string"   },
                { id: "s", label: "מספר קולות", type: "number" }
            ],
            "rows": []
        };
        changeChartObject($scope.Survery.Current.LastDate);
       
    }

    function refresh() {
        $scope.chart = $scope.chartObject; $scope.chart.cssStyle = style;
    }

    loadChartObject();

    refresh();

});
