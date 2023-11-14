# HighparkingP
# Highparking
האתר שלנו עוסק בניהול רשתות חניון 
טבלה status תכונות:1 סוג משתמש
לקוחות customer:ת.ז, סןג משתמש, שם כתובת מייל, מיספר טלפון ,קוד אישי (אופצינלי)  ,מספר חשבון אשראי ,מיספר חשבון בביט, נקודות
טבלת תעריף:(enum)
קבלה:מספר קבלה(אוטומטי), ת.ז, סוג משתמש ,זמן כניסה ,זמן יציאה ,תאריך ,סך הכל לתשלום, סך הכל זמן שהייה 
טבלת status
get-http://hghparking.com/status
put-http://highparking.com/status/{string}//עדכון
post-http://highparking.com/status/{string}//הוספה
delete-http://highparking.com/status/{string}
טבלה  customer:
get-http://hghparking.com/cosrumer
get-http://hghparking.com/cosrumer{id}
put-http://highparking.com/cosrumer{id}
post-http://highparking.com/cosrumer{id}
delete-http://highparking.com/cosrumer{id}
תעריף :

get-http://hghparking.com/rate/{k}
put-http://highparking.com/rate/{k}
post-http://highparking.com/rate/{k}
delete-http://highparking.com/rate/{k}.
