'use strict';
var notify = $.notify('<i class="fa fa-bell-o"></i><strong>Đang tải</strong> không đóng trang này...', {
    type: 'theme',
    allow_dismiss: true,
    delay: 2000,
    showProgressbar: true,
    timer: 300
});

setTimeout(function() {
    notify.update('message', '<i class="fa fa-bell-o"></i><strong>Đang tải</strong> dữ liệu bên trong.');
}, 1000);
