#pragma once


// CFindDialog dialog

class CFindDialog : public CDialogEx
{
	DECLARE_DYNAMIC(CFindDialog)

public:
	CFindDialog(CWnd* pParent = NULL);   // standard constructor
	virtual ~CFindDialog();

// Dialog Data
	enum { IDD = IDD_FIND_DIALOG };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
public:
	CString m_oFind;
};
