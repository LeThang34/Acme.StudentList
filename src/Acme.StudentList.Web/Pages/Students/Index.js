$(function () {
    var l = abp.localization.getResource('StudentList');
    var detailStudentModal = new abp.ModalManager(abp.appPath + 'Students/DetailStudentModal');
    var createModal = new abp.ModalManager(abp.appPath + 'Students/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Students/EditModal');

    var dataTable = $('#StudentsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: false,
            paging: true,
            order: [[1, "asc"]],
            searching: true,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(acme.studentList.students.student.getList),
            columnDefs: [
                {
                    title: l('Thao tác'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Chi tiết'),
                                    action: function (data) {
                                        detailStudentModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    confirmMessage: function (data) {
                                            return l('Xóa sinh viên', data.record.name);
                                    },
                                    action: function (data) {
                                        acme.studentList.students.student
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(
                                                    l('Xóa thành công')
                                                );
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('Class'),
                    data: "class"
                },
                {
                    title: l('Type'),
                    data: "type",
                    render: function (data) {
                        return l('Enum:StudentSex:' + data);
                    }
                },
                
                {
                    title: l('Phone'),
                    data: "phone",
                    searchable: true
                },

                {
                    title: l('Address'),
                    data: "address"
                },
                {
                    title: l('Ngày sinh'),
                    data: "dateOfBirth",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                }
            ]
        })
    );


    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewStudentButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });



    /*createModal.onResult(function () {
        dataTable.ajax.reload();
    });
*/
    /*editModal.onResult(function () {
        dataTable.ajax.reload();
    });*/

    /*$('#NewStudentButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });*/


});
